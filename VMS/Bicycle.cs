using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS
{
    internal class Bicycle : Ivehicle
    {
        public string vehicleType => "Bicycle";
        public FuelType fuel => FuelType.Gasoline;


        public void start()
        {
            Console.WriteLine("the cycle is starting....");
        }
        public void stop() 
        {
            Console.WriteLine("the cycle is stopping........");

        }
    }
}
