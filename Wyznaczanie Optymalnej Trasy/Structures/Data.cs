using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Google.Maps;
using Google.Maps.DistanceMatrix;
using System.Text.RegularExpressions;
using Wyznaczanie_Optymalnej_Trasy.Structures;

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
        static string JSON_FILES_FOLDER = @".\..\..";
        static string HOME_ADDRESS_FILENAME = "HomeAddress.json";
        static string CUSTOMERS_FILENAME = "Customers.json";
        static string DIMENSIONS_MATRIX_FILENAME = "DistancenMatrix.json";
        static string CAR_LIST_FILENAME = "CarsList.json";
        static string CURRENT_CARS_LIST_FILENAME = "CurrentCars.json";

        protected Address homeAddress;
        protected List<Address> customersList;
        protected DistanceMatrixResponse.DistanceMatrixRows[] distanceMatrix;  // size -> 1 + CustomersList.Count
        protected List<Car> carsList;
        protected List<Car> currentCars;

        public Data()
        {
            GoogleSigned.AssignAllServices(new GoogleSigned(Globals.API_KEY));
            homeAddress = Deserialize<Address>(HOME_ADDRESS_FILENAME);
            customersList = Deserialize<List<Address>>(CUSTOMERS_FILENAME);
            distanceMatrix = DeserializeDistanceMatrix(DIMENSIONS_MATRIX_FILENAME);
            carsList = Deserialize<List<Car>>(CAR_LIST_FILENAME);
            currentCars = Deserialize<List<Car>>(CURRENT_CARS_LIST_FILENAME);
        }

        public virtual void SaveData()
        {
            Serialize<List<Address>>(CUSTOMERS_FILENAME, customersList);
            Serialize<Address>(HOME_ADDRESS_FILENAME, homeAddress);
            Serialize<DistanceMatrixResponse.DistanceMatrixRows[]>(DIMENSIONS_MATRIX_FILENAME, distanceMatrix);
            Serialize<List<Car>>(CAR_LIST_FILENAME, carsList);
            Serialize<List<Car>>(CURRENT_CARS_LIST_FILENAME, currentCars);
        }

        public void AddCar(Car car)
        {
            carsList.Add(car);
        }

        public Address HomeAddress()
        {
            return homeAddress;
        }

        public List<Car> AllCarsList()
        {
            return carsList;
        }

        public List<Car> CurrentCars()
        {
            return currentCars;
        }

        public List<Address> AllCustomers()
        {
            return customersList;
        }

        public List<Address> AllAddresses()
        {
            var addresses = new List<Address>() { homeAddress };
            addresses.AddRange(from customer in customersList select customer);

            return addresses;
        }

        public DistanceMatrixResponse.DistanceMatrixRows[] GetDistanceMatrix()
        {
            return distanceMatrix;
        }

        public void UpdateDistanceMatrix()
        {
            var origins = new List<Location>() { homeAddress.AsLocation() };
            var destinations = new List<Location>() { homeAddress.AsLocation() };
            origins.AddRange(from customer in customersList select customer.AsLocation());
            destinations.AddRange(from customer in customersList select customer.AsLocation());

            DistanceMatrixRequest request = new DistanceMatrixRequest()
            {
                WaypointsOrigin = origins,
                WaypointsDestination = destinations
            };
            var response = new DistanceMatrixService().GetResponse(request);
            if (response.Status == 0)
                throw new Exception("Invalid address");

            distanceMatrix = response.Rows;
        }

        public List<string> getCustomersNamesForSpecifiedDay(Address.Day day)
        {
            return (from user in customersList
                                      where user.isSubscribedForDay(day)
                                      select user.name).ToList();
        }

        public double[,] getDistancesForSpecifiedDay(Address.Day day)
        {
            return getSpecifiedDistances(getCustomersNamesForSpecifiedDay(day));
        }

        public double[,] getDurationsForSpecifiedDay(Address.Day day)
        {
            List<string> customers = (from user in customersList
                                      where user.isSubscribedForDay(day)
                                      select user.name).ToList();
            return getSpecifiedDurations(customers);
        }

        public double[,] getSpecifiedDistances(List<string> customersNames)
        {
            List<int> indexes = new List<int>() { 0 };
            foreach (string name in customersNames) // TODO: refactor
            {
                indexes.Add(customersList.FindIndex(a => a.name == name) + 1);
            }
            double[,] distances = new double[indexes.Count(), indexes.Count()];

            int res_i = 0;
            foreach (int i in indexes)
            {
                int res_j = 0;
                DistanceMatrixResponse.DistanceMatrixElement[] elements = distanceMatrix[i].Elements;
                foreach (int j in indexes)
                {
                    distances[res_i, res_j] = DistancestringToDecimal(elements[j].distance.Text);
                    res_j++;
                }
                res_i++;
            }

            return distances;
        }

        public double[,] getSpecifiedDurations(List<string> customersNames)
        {
            List<int> indexes = new List<int>() { 0 };
            foreach (string name in customersNames) // TODO: refactor
            {
                indexes.Add(customersList.FindIndex(a => a.name == name) + 1);
            }
            double[,] durations = new double[indexes.Count(), indexes.Count()];

            int res_i = 0;
            foreach (int i in indexes)
            {
                int res_j = 0;
                DistanceMatrixResponse.DistanceMatrixElement[] elements = distanceMatrix[i].Elements;
                foreach (int j in indexes)
                {
                    durations[res_i, res_j] = DurationStringToDecimal(elements[j].duration.Text);
                    res_j++;
                }
                res_i++;
            }

            return durations;
        }

        public void AddCustomer(Address address)
        {
            customersList.Add(address);
        }

        public void AddCustomer(
            string name, decimal latitude, decimal longitude
            )
        {
            Address customer = new Address(name, latitude, longitude);
            customersList.Add(customer);
        }

        public void AddCustomer(
            string name, decimal latitude, decimal longitude, string street, int buildingNumber,
            int houseNumber, string zipcode, string city, string country
            )
        {
            Address customer = new Address(
                name, latitude, longitude, street, buildingNumber, houseNumber, zipcode, city, country
                );
            customersList.Add(customer);
        }

        private T Deserialize<T>(string filename) where T : new()
        {
            try
            {
                using (
                    System.IO.StreamReader stream = new System.IO.StreamReader(
                        System.IO.Path.Combine(JSON_FILES_FOLDER, filename)
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
                        System.IO.Path.Combine(JSON_FILES_FOLDER, filename)
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
                return new DistanceMatrixResponse.DistanceMatrixRows[customersList.Count * customersList.Count];
            }
        }

        private void Serialize<T>(string filename, T data)
        {
            string jsonData = JsonConvert.SerializeObject(data);
            System.IO.File.WriteAllText(System.IO.Path.Combine(JSON_FILES_FOLDER, filename), jsonData);
        }

        private double DurationStringToDecimal(string durationString)
        {
            // TODO: refactor and optimize
            double result = 0.0;

            string hoursPattern = @"(\d+)(?=\shour)";
            string minsPattern = @"(\d+)(?=\smin)";

            Regex rH = new Regex(hoursPattern, RegexOptions.IgnoreCase);
            Match mH = rH.Match(durationString);

            string hString = mH.Groups.Count == 2 ? mH.Groups[1].ToString() : "0";
            result += Convert.ToDouble(hString);

            Regex rM = new Regex(minsPattern, RegexOptions.IgnoreCase);
            Match mM = rM.Match(durationString);

            string mString = mM.Groups.Count == 2 ? mM.Groups[1].ToString() : "0";
            result += Convert.ToDouble(mString) / 60.0;

            return result;
        }

        private double DistancestringToDecimal(string distanceString)
        {
            if (distanceString.Contains("km"))
            {
                return Convert.ToDouble(distanceString.Replace(" km", "").Replace(".", ","));
            }
            else if (distanceString.Contains("m"))
            {
                return Convert.ToDouble(distanceString.Replace("m", "").Replace(".", ",")) / 1000.0;
            }
            else 
            {
                return 0.0;
            }
        }

    }

    public class DataCopy : Data 
    {
        public DataCopy(Data other)
        {
            GoogleSigned.AssignAllServices(new GoogleSigned(Globals.API_KEY));
            homeAddress = other.HomeAddress();
            customersList = new List<Address>(other.AllCustomers().ToList());
            distanceMatrix = (DistanceMatrixResponse.DistanceMatrixRows[])other.GetDistanceMatrix().Clone();
            carsList = new List<Car>(other.AllCarsList().ToList());
            currentCars = new List<Car>(other.CurrentCars());
        }

        public DataCopy()
        { }

        public override void SaveData()
        {}
    }
}
