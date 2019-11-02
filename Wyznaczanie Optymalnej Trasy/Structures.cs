using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Maps;

namespace Wyznaczanie_Optymalnej_Trasy
{
    [Serializable]
    public struct Coordinates
    {
        public decimal Latitude;
        public decimal Longitude;
    
        public Coordinates(decimal latitude, decimal longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public override string ToString()
        {
            var d = Latitude.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) 
                + "," + 
                Longitude.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            return d;
        }
    }


    [Serializable]
     public class Customer
    {
        public string Name = default;
        public Coordinates Coordinates = default;
        public string Street = default;
        public int BuildingNumber = default;
        public int HouseNumber = default;
        public string ZipCode = default;
        public string City = default;
        public string Country = "PL"; // TODO: check if google api accepts country and adjust

        public Customer()
        { 
        }

        public Customer(string name, decimal latitude, decimal longitude)
        {
            Name = name;
            Coordinates = new Coordinates(latitude, longitude);
        }
        public Customer(
            string name, decimal latitude, decimal longitude, string street, int buildingNumber,
            int houseNumber, string zipcode, string city, string country
            )
        {
            Name = name;
            Coordinates = new Coordinates(latitude, longitude);
            Street = street;
            BuildingNumber = buildingNumber;
            HouseNumber = houseNumber;
            ZipCode = zipcode;
            City = city;
            Country = country;
        }

        public Location AsLocation()
        {
            if (!Object.Equals(Coordinates, default))
            {
                return new Location(Coordinates.ToString());
            }
            else
            {
                string locationString = Street + BuildingNumber.ToString() + ZipCode + City;
                return new Location(locationString);
            }
        }
    }

}
