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
            //Console.WriteLine("dystans dla trasy początkowej: " + tgw.Road_distance(dist));
            while (T >= Tk)
            {
                t.rand_road("insert");
                tpr.copy(t);
                double tgw_d = tgw.Road_distance(dist);
                double t_d = t.Road_distance(dist);
                double tpr_d = tpr.Road_distance(dist);
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
            return tgw;
        }
    }
}
