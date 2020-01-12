using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wyznaczanie_Optymalnej_Trasy.Algorithms.utils;
using Wyznaczanie_Optymalnej_Trasy.Structures;
using static Wyznaczanie_Optymalnej_Trasy.Address;

namespace Wyznaczanie_Optymalnej_Trasy
{
    public class CarFleetExpansionAlgorithm     {
        public class Result
        {
            public bool carShouldBeBuyed;
            public Car carType;
            public int numberOfWeeks;

            public Result()
            {
                this.carShouldBeBuyed = false;
                this.carType = null;
                this.numberOfWeeks = 0;
            }

            public Result(bool carShouldBeBuyed, Car carType, int numberOfWeeks)
            {
                this.carShouldBeBuyed = carShouldBeBuyed;
                this.carType = carType;
                this.numberOfWeeks = numberOfWeeks;
            }
        }
        
        private static Random rnd = new Random();

        public static bool getRandomDecisionAboutNewCustomerFromNormalDistribution(double mean = 0, double stdDev = 0.2)
        {
            Normal normalDistribution = new Normal(mean, stdDev);
            return System.Convert.ToBoolean(normalDistribution.Sample());
        }

        public static bool getRandomDecisionAboutNewCustomer()
        {
            return System.Convert.ToBoolean(rnd.Next(0, 2));
        }

        public static Address getRandomCustomer()
        {
            Address result = null;

            if (getRandomDecisionAboutNewCustomer())
            {
                Coordinates coordinates = RandomCoordinates.GetRandomCoordinatesInPoland();
                List <Day> days = new List<Day>();
                
                for (int i = 0; i < 7; i++) // TODO: change to generic solution
                {
                    if (System.Convert.ToBoolean(rnd.Next(0, 2)))
                    {
                        days.Add((Day)i);
                    }
                }

                result = new Address();
                result.addressCoordinates = coordinates;
                result.deliveryDays = days;
            }

            return result;
        }

        public static Result getDecision(
            int weeksNumber,
            int currentCarsNumber,
            float empleyeesHourlyRate,
            float dailyPenalty,
            List<Car> carsList,
            List<Address> customersAddresses,
            List<Address> allAddresses
            )
        {
            return new Result();
        }
    }
}
