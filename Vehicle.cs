using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    abstract class Vehicle
    {
        public int FuelCapacity { get; set; }
        public Color Color { get; set; }
        public int Occupancy { get; set; }

        public abstract void Refuel();
        public virtual void Driving()
        {
            Console.WriteLine("The vehicle is now being driven");
        }
    }
}
