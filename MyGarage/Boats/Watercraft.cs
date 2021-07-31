using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    class Watercraft : Vehicle
    {
        public override void Refuel()
        {
            Console.WriteLine("The watercraft is being refueld");
        }
    }
}
