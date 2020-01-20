using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wyznaczanie_Optymalnej_Trasy.Structures;
using Wyznaczanie_Optymalnej_Trasy.Algorithms.utils;
using Wyznaczanie_Optymalnej_Trasy;

namespace Simulated_annealing
{
    class SA
    {
        public static SA_Result Start_SA(double T0, double Tk, double lambda, Data data, List<string> customers, Distance dist, Distance fuelDist, SA_Result oldResult)
        {
            int Car = data.CurrentCars().Count;
            int[] CarCapacity = new int[Car];

            for (int i = 0; i < Car; i++)
            {
                CarCapacity[i] = data.CurrentCars()[i].capacity;
            }
            int maxCapacity = CarCapacity.Sum();

            
            double Time_Max = 12;
            double T = T0;
            Sequence t = new Sequence(Car, dist.City);
            Sequence tpr = new Sequence(Car, dist.City);
            Sequence tgw = new Sequence(Car, dist.City);
            int outOfCapacity = 0;
            while (T >= Tk)
            {
                if (dist.City > maxCapacity)
                {
                    outOfCapacity = 1;
                    break;
                }
                t.rand_road("insert");
                tpr.copy(t);
                double tgw_d = tgw.Road_distance(dist,CarCapacity);
                double t_d = t.Road_distance(dist, CarCapacity);
                double tpr_d = tpr.Road_distance(dist, CarCapacity);
                if (tgw_d > t_d)
                {
                    tgw.copy(t);
                }
                if (tpr_d - t_d <= 0)
                {
                    t.copy(tpr);
                }
                else if (new Random().NextDouble() <= Math.Exp(-(tpr_d - t_d) / T))
                {
                    t.copy(tpr);
                }
                T = lambda * T;
            }
            oldResult.optimal_road = tgw;
            if (Time_Max < tgw.Road_distance(dist, CarCapacity)&& customers.Count>0 || outOfCapacity == 1)
            {
                
                double[] dist_array = tgw.All_distance(dist);
                double maxDist = dist_array.Max();
                double maxIndex = dist_array.ToList().IndexOf(maxDist);
                int retCity = OutPointLF(dist, tgw);
                oldResult.ReturnCityString.Add(customers[retCity]);
                customers.RemoveAt(retCity);
                Distance dist_new = dist.OutPoint(retCity);
                Distance fuelDist_new = fuelDist.OutPoint(retCity); // ????
                oldResult = Start_SA(T0, Tk, lambda, data, customers, dist_new, fuelDist_new, oldResult);
            }
            //TODO: licznenie ile kilometrów przejechały samochody 
            //Distance dist_km = new Distance(new double[,], "", "");
            //oldResult.fuel = tgw.All_distance(dist_km);
            //oldResult.fuel = tgw.All_distance(fuelDist).Sum();
            double[] fuelByCar = tgw.All_distance(fuelDist);
            for (int i = 0; i < Car; i++)
            {
                oldResult.fuel += data.CurrentCars()[i].kmCost * fuelByCar[i];
            }
            oldResult.workTime = tgw.All_distance(dist).Sum();
            
            return oldResult;
        }

        public static int OutPointLF(Distance dist,Sequence tgw)
        {
            int outPoint = 0;
            for (int i = 0; i < tgw.City + tgw.Car; i++)
            {
                int j = 0;
                if (j == 0 && tgw.Road[i] == 0)
                {
                    j = i;
                }
                else if (j > 0 && tgw.Road[i] == 0)
                {
                    double[] outDistance = new double[i - j];
                    for (int k = j + 1; k < j - i - 1; k++)
                    {
                        outDistance[k] = dist.Get(0, k);
                    }
                    outPoint = outDistance.ToList().IndexOf(outDistance.Min());
                    break;
                }
            }
            return outPoint;
        }
    }
}
