using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    class Aircraft : Vehicle
    {
        public override void Refuel()
        {
            Console.WriteLine("The aircraft is now being refueled");
        }

        public void Flying()
        {
            Console.WriteLine("The aircraft is being flown");
        }

        public void Landing()
        {
            Console.WriteLine("The aircraft is landing");
        }
    }
}
