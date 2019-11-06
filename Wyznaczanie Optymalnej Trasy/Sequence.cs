﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulated_annealing
{
    class Sequence
    {
        public int[] Road;
        private int Car;
        private int City;

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
        public void rand_road()
        {
            Random rnd = new Random();
            int from = rnd.Next(1, City + Car - 1);
            int to = rnd.Next(1, City + Car -1);
            if (from > to)
            {
                from = to - from + (to = from);
            }
            int temp = Road[from];
            for (int i = from; i < to; i++)
            {
                Road[i] = Road[i + 1];
            }
            Road[to] = temp;
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
    }
}