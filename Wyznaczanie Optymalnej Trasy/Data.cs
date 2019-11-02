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

        //TODO: check if decimal[,] is ok
        public decimal[,] getSpecificDistances(List<string> customersNames)
        {
            List<int> indexes = Enumerable.Range(0, CustomersList.Count).Where(
                i => customersNames.Contains(CustomersList[i].Name)
                ).ToList();

            decimal[,] distances = new decimal[indexes.Count(), indexes.Count()];

            foreach(int i in indexes)
            {
                DistanceMatrixResponse.DistanceMatrixElement[] elements = DistanceMatrix[i].Elements;
                foreach(int j in indexes)
                {
                    //distances[i, j] = Convert.ToDecimal(elements[j].distance.Text);
                    Console.WriteLine(elements[j].distance.Text);
                }
            }

            return distances;
        }
    }
}
