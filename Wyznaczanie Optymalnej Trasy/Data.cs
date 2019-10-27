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

    //  Probably this structures will be changed
    static class Globals
    {
        public const bool AllowGoogleApiOperations = true;
        public const string API_KEY = "AIzaSyATIIYDzB6wVmdywhGVSmRLOWYrMHkrWBM";
    }

    public class Data
    {
        // Data class should be initialized on program startup.
        static string JsonFilesFolder = @".\..\..";
        static string CustomersJsonFilename = "Customers.json";
        static string DimensionMatrixJsonFilename = "DimensionMatrix.json";
        public List<Customer> CustomersList;
        // TODO: Check if this type is ok (maybe List<Lits<DistanceMatrixElement>>)
        public List<DistanceMatrixResponse.DistanceMatrixRows> DimensionMatrix;

        public Data()
        {
            GoogleSigned.AssignAllServices(new GoogleSigned(Globals.API_KEY));
            CustomersList = Deserialize<List<Customer>>(CustomersJsonFilename);
            DimensionMatrix = Deserialize<List<DistanceMatrixResponse.DistanceMatrixRows>>(DimensionMatrixJsonFilename);
        }

        ~Data()
        {
            Serialize<List<Customer>>(CustomersJsonFilename, CustomersList);
            Serialize<List<DistanceMatrixResponse.DistanceMatrixRows>>(DimensionMatrixJsonFilename, DimensionMatrix);
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

        public void UpdateDimensionMatrix()
        {
            // NOT TESTED!!!!!!!!!
            if (Globals.AllowGoogleApiOperations)
            {
                DistanceMatrixRequest request = new DistanceMatrixRequest()
                {
                    WaypointsOrigin = new List<Location> (from customer in CustomersList select customer.AsLocation()),
                    WaypointsDestination = new List<Location>(from customer in CustomersList select customer.AsLocation())
                };
                //var response = new DistanceMatrixService().GetResponse(request);
                // TODO: Convert distancematrix rows to List<DistanceMatrixResponse.DistanceMatrixRows> and assign
            }
        }
    }
}
