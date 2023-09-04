using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS
{
    internal class Bus : Ivehicle, IDrivable
    {
        public string vehicleType => "Bus";
        public FuelType fuel => FuelType.Diesel;

        public void start()
        {
            Console.WriteLine("the bus is starting....");
        }
        public void stop()
        {
            Console.WriteLine("the bus is stopping........");
        }
        public void accelerate()
        {
            Console.WriteLine("buses can accelerate.......");
        }
    }
}
