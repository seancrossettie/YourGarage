using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage.MyGarage.Cars
{
    class BMW : Car
    { 
        public bool TurboEngine { get; set; }

        public void RearBackupCam()
        {
            Console.WriteLine($"Your BMW {Model} is using its rear backup cam.");
        }

        public BMW(string model)
        {
            Model = model;
        }

        public override void Driving()
        {
            if (TurboEngine)
            {
                Console.WriteLine("Your BMW {Model} has a turbo engine and can whip");
            } else
            {
                Console.WriteLine("Your BMW {Model} is driving");
            }
        }
    }
}
