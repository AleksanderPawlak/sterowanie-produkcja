using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulated_annealing
{
    public class Sequence
    {
        public int[] Road;
        public int Car;
        public int City;

        public Sequence(int car, int city)
        {
            Car = car;
            City = city;
            Road = new int[city + car];
            for (int i = 0; i < city; i++)
            {
                Road[i] = i;
            }
            for (int i = city; i < city + car; i++)
            {
                Road[i] = 0;
            }
        }
        public void rand_road(string type)
        {
            Random rnd = new Random();
            int from = rnd.Next(1, City + Car - 1);
            int to = rnd.Next(1, City + Car - 1);
            if (from > to)
            {
                from = to - from + (to = from);
            }

            switch (type)
            {
                case "insert":
                    int temp = Road[from];
                    for (int i = from; i < to; i++)
                    {
                        Road[i] = Road[i + 1];
                    }
                    Road[to] = temp;
                    break;
                case "swap":
                    Road[from] = Road[to] - Road[from] + (Road[to] = Road[from]);
                    break;
                case "invert":
                    for (int i = 0; i < decimal.ToInt32(Math.Floor(new decimal((to - from)/2))); i++)
                    {
                        Road[from + i] = Road[to - i] - Road[from + i] + (Road[to - i] = Road[from + i]);
                    }
                    break;
                default:
                    break;
            }
        }
        public void print_road()
        {
            foreach (var item in Road)
            {
                Console.Write((item+1) + " ");
            }
            Console.WriteLine();
        }
        public void copy(Sequence arg)
        {
            for (int i = 0; i < arg.Road.Count(); i++)
            {
                Road[i] = arg.Road[i];
            }
        }
        public double Road_distance(Distance arg)
        {
            double[] L = new double[Car];
            int j = 0;
            for (int i = 0; i < Car; i++)
            {
                do
                {
                    L[i] += arg.Get(Road[j], Road[j + 1]);
                    j++;
                } while (Road[j]!=0);
            }
            return L.Max();
        }
        public double[] All_distance(Distance arg)
        {
            double[] L = new double[Car];
            int j = 0;
            for (int i = 0; i < Car; i++)
            {
                do
                {
                    L[i] += arg.Get(Road[j], Road[j + 1]);
                    j++;
                } while (Road[j] != 0);
            }
            return L;
        }
    }
}