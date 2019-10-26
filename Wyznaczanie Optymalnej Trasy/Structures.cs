using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Maps;

namespace Wyznaczanie_Optymalnej_Trasy.Google
{
    public class Address  // Maybe Google.maps have structures for that
    {
        //public PointLatLng Coordinates;
        public LatLng Coordinates { get; set; } = default;
        public string Street;
        public int BuildingNumber;
        public int HouseNumber;
        public string ZipCode;
        public string City;
        public string Country;

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

     public class Customer
    {
        public string Name;
        public Address Address;   


    }

}
