using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Maps;

namespace Wyznaczanie_Optymalnej_Trasy
{
 
    [Serializable]
     public class Address
    {
        public string name = default;
        public Coordinates addressCoordinates = default;
        public string street = default;
        public int buildingNumber = default;
        public int houseNumber = default;
        public string zipCode = default;
        public string city = default;
        public string country = "PL"; // TODO: check if google api accepts country and adjust
        public Day[] deliveryDays = new Day[7];  // TODO: create setter with size limit

        [Serializable]
        public enum Day
        {
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat,
            Sun
        }

        [Serializable]
        public struct Coordinates
        {
            public decimal latitude;
            public decimal longitude;

            public Coordinates(decimal latitude, decimal longitude)
            {
                this.latitude = latitude;
                this.longitude = longitude;
            }

            public override string ToString()
            {
                var d = latitude.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)
                    + "," +
                    longitude.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
                return d;
            }
        }

        public Address()
        { 
        }

        public Address(string name, decimal latitude, decimal longitude)
        {
            this.name = name;
            addressCoordinates = new Coordinates(latitude, longitude);
        }
        public Address(
            string name, decimal latitude, decimal longitude, string street, int buildingNumber,
            int houseNumber, string zipcode, string city, string country
            )
        {
            this.name = name;
            this.addressCoordinates = new Coordinates(latitude, longitude);
            this.street = street;
            this.buildingNumber = buildingNumber;
            this.houseNumber = houseNumber;
            zipCode = zipcode;
            this.city = city;
            this.country = country;
        }

        public Address(
            string name, decimal latitude, decimal longitude, string street, int buildingNumber,
            int houseNumber, string zipcode, string city, string country, Day[] deliveryDays
            )
        {
            this.name = name;
            this.addressCoordinates = new Coordinates(latitude, longitude);
            this.street = street;
            this.buildingNumber = buildingNumber;
            this.houseNumber = houseNumber;
            zipCode = zipcode;
            this.city = city;
            this.country = country;
            this.deliveryDays = deliveryDays;
        }

        public bool isSubscribedForDay(Day day)
        {
            return deliveryDays.Contains(day);
        }

        public Location AsLocation()
        {
            if (!Object.Equals(addressCoordinates, default))
            {
                return new Location(addressCoordinates.ToString());
            }
            else
            {
                string locationString = street + buildingNumber.ToString() + zipCode + city;
                return new Location(locationString);
            }
        }
    }

}
