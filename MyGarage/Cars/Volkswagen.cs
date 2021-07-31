using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage.MyGarage.Cars
{
    class VW : Car
    {
        public bool FailedEmissions { get; set; }
        public VW(string model)
        {
            Model = model;
        }

        public void EnvironmentalScandal()
        {
            if (FailedEmissions)
            {
                Console.WriteLine($"By owning this VW {Model}, you are destroying the environment");
            } else
            {
                Console.WriteLine($"By owning this VW {Model}, you are not destroying the environment");
            }
        }
    }
}
