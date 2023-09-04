using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS
{
    internal class Car:Ivehicle ,IDrivable
    {
        public string vehicleType => "Car";
        public FuelType fuel => FuelType.Petrol;
        public void start()
        {
            Console.WriteLine("the car is starting....");
        }
        public void stop()
        {
            Console.WriteLine("the car is stopping........");
        }
        public void accelerate()
        {
            Console.WriteLine("cars can accelerate.......");
        }
    }
}
