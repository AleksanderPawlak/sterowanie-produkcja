using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyznaczanie_Optymalnej_Trasy.Structures
{
    [Serializable]
    public class Car
    {
        public string model { get; set; }
        public string brand { get; set; }
        public float kmCost { get; set; }
        public float carCost { get; set; }

        public int capacity { get; set; }

        public Car()
        { }

        public Car(string model, string brand, float kmCost, float carCost, int capacity)
        {
            this.model = model;
            this.brand = brand;
            this.kmCost = kmCost;
            this.carCost = carCost;
            this.capacity = capacity;
        }
    }
}
