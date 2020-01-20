using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wyznaczanie_Optymalnej_Trasy.Algorithms.utils;
using Wyznaczanie_Optymalnej_Trasy.Structures;
using static Wyznaczanie_Optymalnej_Trasy.Address;
using Simulated_annealing;

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

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

        public static Address getRandomCustomer()
        {
            Address result = new Address();
                
            Coordinates coordinates = RandomCoordinates.GetRandomCoordinatesInPoland();
            List <Day> days = new List<Day>();
                
            for (int i = 0; i < 7; i++) // TODO: change to generic solution
            {
                if (System.Convert.ToBoolean(rnd.Next(0, 2)))
                {
                    days.Add((Day)i);
                }
            }

            result.name = RandomString(15);
            result.addressCoordinates = coordinates;
            result.deliveryDays = days;

            return result;
        }

        private static void addRandomCustomer(Data data) // TODO: refactor (bardzo zle rozwiazanie)
        {
            if (!getRandomDecisionAboutNewCustomer())
                return;

            bool error = false;

            do
            {
                try
                {
                    Address randomCustomer = getRandomCustomer();
                    data.AddCustomer(randomCustomer);
                    data.UpdateDistanceMatrix();

                }
                catch (Exception)
                {
                    error = true;
                }
            }
            while (error);
        }

        public static Result getDecision(
            int weeksNumber,
            float empleyeesHourlyRate,
            float dailyPenalty,
            Data dataMainCopy
            )
        {
            List<string> customers = new List<string>();
            double[,] costFunction = new double[weeksNumber, dataMainCopy.AllCarsList().Count+1];
            for (int k = 0; k < dataMainCopy.AllCarsList().Count+1; k++)
            {
                DataCopy data = new DataCopy(dataMainCopy);
                int dayLate = 0;
                SA_Result result = new SA_Result();
                List<Car> Cars = data.CurrentCars(); // create car list k=0 -> current cars, k>0 ->current cars + new car
                if (k > 0) 
                {
                    Cars.Add(data.AllCarsList()[k - 1]);
                }

                for (int i = 0; i < weeksNumber; i++)
                {
                    addRandomCustomer(data);

                    for (int j = 0; j < 7; j++)
                    {

                        Day day = (Day)i;
                        customers.AddRange(data.getCustomersNamesForSpecifiedDay(day));
                        double[,] durations = data.getSpecifiedDurations(customers);
                        double[,] distances = data.getSpecifiedDistances(customers); 

                        if (customers != null)
                        {
                            result = SA.Start_SA(
                                1000,
                                0.0001,
                                0.9,
                                data,
                                customers,
                                new Distance(durations, "", ""),
                                new Distance(distances, "", ""),
                                result
                                );

                            customers = result.ReturnCityString;
                            costFunction[i, k] += customers.Count * dailyPenalty;
                            costFunction[i, k] += result.fuel;
                            costFunction[i, k] += result.workTime * empleyeesHourlyRate;
                        }
                    }
                    if (k > 0)
                    {
                        costFunction[i, k] += data.AllCarsList()[k - 1].carCost / (3 * 52);
                    }
                    if (customers != null)
                    {
                        dayLate++;
                    }
                }
                if (dayLate > weeksNumber*0.8)
                {
                    for (int i = 0; i < weeksNumber; i++)
                    {
                        costFunction[i, k] += dayLate * 1000;
                    }
                }
            }
            int simNumber = dataMainCopy.AllCarsList().Count + 1;
            double[] endCF = new double[simNumber];
            for (int i = 0; i < simNumber; i++)
            {
                endCF[i] = costFunction[weeksNumber-1, i];
            }

            if (endCF[0] == endCF.Min())
                return new Result();
            else
            {
                int minCF = endCF.ToList().IndexOf(endCF.Min()) - 1;
                
                return new Result(true, dataMainCopy.AllCarsList()[minCF],1);
            }

            
            
        }
    }
}
