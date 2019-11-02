using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Google.Maps;
using Google.Maps.DistanceMatrix;

namespace Wyznaczanie_Optymalnej_Trasy
{

    //  Probably these structures will be changed
    static class Globals
    {
        public const bool AllowGoogleApiOperations = true;
        public const string API_KEY = "";
    }

    public class Data
    {
        // Data class should be initialized on program startup.
        static string JsonFilesFolder = @".\..\..";
        static string CustomersJsonFilename = "Customers.json";
        static string DimensionMatrixJsonFilename = "DimensionMatrix.json";
        public List<Customer> CustomersList;
        public DistanceMatrixResponse.DistanceMatrixRows[] DistanceMatrix;
        public DistanceMatrixResponse resss;

        public Data()
        {
            GoogleSigned.AssignAllServices(new GoogleSigned(Globals.API_KEY));
            CustomersList = Deserialize<List<Customer>>(CustomersJsonFilename);
            DistanceMatrix = DeserializeDistanceMatrix(DimensionMatrixJsonFilename);
            resss = Deserialize<DistanceMatrixResponse>("response.json");
        }

        ~Data()
        {
            Serialize<List<Customer>>(CustomersJsonFilename, CustomersList);
            Serialize<DistanceMatrixResponse.DistanceMatrixRows[]>(DimensionMatrixJsonFilename, DistanceMatrix);
            Serialize<DistanceMatrixResponse>("response.json", resss);
        }

        private T Deserialize<T>(string filename) where T : new()
        {
            try
            {
                using (
                    System.IO.StreamReader stream = new System.IO.StreamReader(
                        System.IO.Path.Combine(JsonFilesFolder, filename)
                        )
                    )
                {
                    return JsonConvert.DeserializeObject<T>(stream.ReadToEnd());
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                return new T();
            }
        }

        private DistanceMatrixResponse.DistanceMatrixRows[] DeserializeDistanceMatrix(string filename)
        {
            try
            {
                using (
                    System.IO.StreamReader stream = new System.IO.StreamReader(
                        System.IO.Path.Combine(JsonFilesFolder, filename)
                        )
                    )
                {
                    return JsonConvert.DeserializeObject<
                        DistanceMatrixResponse.DistanceMatrixRows[]
                        >(stream.ReadToEnd());
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                return new DistanceMatrixResponse.DistanceMatrixRows[CustomersList.Count * CustomersList.Count];
            }
        }

        private void Serialize<T>(string filename, T data)
        {
            string jsonData = JsonConvert.SerializeObject(data);
            System.IO.File.WriteAllText(System.IO.Path.Combine(JsonFilesFolder, filename), jsonData);
        }

        public void AddCustomer(
            string name, decimal latitude, decimal longitude
            )
        {
            Customer customer = new Customer(name, latitude, longitude);
            CustomersList.Add(customer);
        }

        public void AddCustomer(
            string name, decimal latitude, decimal longitude, string street, int buildingNumber, 
            int houseNumber, string zipcode, string city, string country
            )
        {
            Customer customer = new Customer(
                name, latitude, longitude, street, buildingNumber, houseNumber, zipcode, city, country
                );
            CustomersList.Add(customer);
        }

        private double DistancestringToDecimal(string distanceString)
        {
            if (distanceString.Contains("km"))
            {
                return Convert.ToDouble(distanceString.Replace(" km", ""));
            }
            else if (distanceString.Contains("m"))
            {
                return Convert.ToDouble(distanceString.Replace("m", "")) / 1000.0;
            }
            else 
            {
                return 0.0;
            }
        }

        public void UpdateDistanceMatrix()
        {
            // TESTED... (should be ok)
            var origins = new List<Location>(from customer in CustomersList select customer.AsLocation());
            var destinations = new List<Location>(from customer in CustomersList select customer.AsLocation());

            DistanceMatrixRequest request = new DistanceMatrixRequest()
            {
                WaypointsOrigin = origins,
                WaypointsDestination = destinations
            };
            var response = new DistanceMatrixService().GetResponse(request);
            resss = response;  // TODO: remove resss
            DistanceMatrix = response.Rows;
        }
         
        // TODO: check if double[,] is ok
        // TODO: refactor
        public double[,] getSpecificDistances(List<string> customersNames)
        {
            List<int> indexes = Enumerable.Range(0, CustomersList.Count)
                .Where(i => customersNames.Contains(CustomersList[i].Name)).ToList();
            double[,] distances = new double[indexes.Count(), indexes.Count()];
            
            int res_i = 0;
            foreach (int i in indexes)
            {
                int res_j = 0;
                DistanceMatrixResponse.DistanceMatrixElement[] elements = DistanceMatrix[i].Elements;
                foreach (int j in indexes)
                {
                    distances[res_i, res_j] = DistancestringToDecimal(elements[j].distance.Text);
                    res_j++;
                }
                res_i++;
            }

            return distances;
        }
    }
}
