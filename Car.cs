using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    class Car : Vehicle
    {
        public void Brake()
        {
            Console.WriteLine("The car is now braking");
        }

        public override void Refuel()
        {
            Console.WriteLine("The car is now being refueled");
        }
    }
}
