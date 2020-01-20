using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulated_annealing;

namespace Wyznaczanie_Optymalnej_Trasy.Algorithms.utils
{
    class SA_Result
    {
        public Sequence optimal_road;
        public List<int> ReturnCity = new List<int>();
        public List<string> ReturnCityString = new List<string>();
        public double workTime;
        public double fuel;
        public SA_Result() 
        { 
        
        }
    }
}
