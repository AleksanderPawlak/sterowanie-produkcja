using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulated_annealing
{
    class SA
    {
        public static Sequence Start_SA(double T0, double Tk, double lambda, int Car, Distance dist)
        {
            double T = T0;
            Sequence t = new Sequence(Car, dist.City);
            Sequence tpr = new Sequence(Car, dist.City);
            Sequence tgw = new Sequence(Car, dist.City);
            Console.WriteLine("dystans dla trasy początkowej: " + tgw.Road_distance(dist));
            while (T >= Tk)
            {
                t.rand_road();
                tpr.copy(t);
                if (tgw.Road_distance(dist) > t.Road_distance(dist))
                {
                    tgw.copy(t);
                }
                if (tpr.Road_distance(dist) - t.Road_distance(dist) <= 0)
                {
                    t.copy(tpr);
                }
                else if (new Random().NextDouble() <= Math.Exp(-(tpr.Road_distance(dist) - t.Road_distance(dist)) / T))
                {
                    t.copy(tpr);
                }
                T = lambda * T;
            }
            return tgw;
        }
    }
}
