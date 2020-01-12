using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Simulated_annealing
{
    public class Distance
    {
        private double[,] distance;
        private double[,] point;
        public int City;

        public Distance(double [,] array, string path = "", string data_type = "")
        {
            if (data_type == "distance")
            {
                var lines = File.ReadAllLines(path);
                distance = new double[lines.Count(), lines.Count()];
                City = lines.Count();

                for (int i = 0; i < lines.Count(); i++)
                {
                    var line = lines[i].Split(';');
                    for (int j = 0; j < lines.Count(); j++)
                    {
                        distance[i, j] = Int32.Parse(line[j]);
                    }
                }
            }
            else if(data_type == "point")
            {
                var lines = File.ReadAllLines(path);
                distance = new double[lines.Count(), lines.Count()];
                point = new double[lines.Count(), 2];
                City = lines.Count();

                for (int i = 0; i < lines.Count(); i++)
                {
                    var line = lines[i].Split(';');
                    for (int j = 0; j < 2; j++)
                    {
                        string tmp = line[j];
                        point[i, j] = Double.Parse(tmp);
                    }
                }
                for (int i = 0; i < City; i++)
                {
                    for (int j = 0; j < City; j++)
                    {
                        distance[i, j] = Math.Sqrt(Math.Pow(point[i, 1] - point[j, 1], 2) + Math.Pow(point[i, 0] - point[j, 0], 2));
                    }

                }
            }
            else
            {
                distance = array;
                City = Convert.ToInt32(Math.Sqrt(distance.Length));
            }
        }

        public double Get(int i,int j)
        {
            return distance[i,j];
        }
    }
}
