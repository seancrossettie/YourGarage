using System;
using System.Collections.Generic;
using YourGarage.MyGarage.Cars;

namespace YourGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The following cars are what I have in my garage:");
            var cars = new List<Car>() { new BMW("X5"), new VW("Passatt") };

            foreach (var car in cars)
            {
                car.Brake();
                car.Refuel();
            }
        }
    }
}
