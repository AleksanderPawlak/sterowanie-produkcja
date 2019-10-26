using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Maps;

namespace Wyznaczanie_Optymalnej_Trasy
{
     public class Customer
    {
        public string Name;
        // Maybe Google.maps have structures for that
        public LatLng Coordinates { get; set; } = default;
        public string Street;
        public int BuildingNumber;
        public int HouseNumber;
        public string ZipCode;
        public string City;
        public string Country;

        public Customer(
            string name, decimal latitude, decimal longitude, string street, int buildingNumber,
            int houseNumber, string zipcode, string city, string country
            )
        {
            Name = name;
            Coordinates = new LatLng(latitude, longitude);
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
