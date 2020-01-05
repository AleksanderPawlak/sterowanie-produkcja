using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wyznaczanie_Optymalnej_Trasy.Structures;

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
        
        bool getRandomDecisionAboutNewCustomerFromNormalDistribution(double mean = 0, double stdDev = 0.2)
        {
            Normal normalDistribution = new Normal(mean, stdDev);
            return System.Convert.ToBoolean(normalDistribution.Sample());
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
