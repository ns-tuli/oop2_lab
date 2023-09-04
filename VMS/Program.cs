using System;
using VMS;

namespace VMS
{
    class Program
    {   
        static void Main(string[] args) 
        {
            Console.WriteLine("press a key :");
            Console.WriteLine("0.to select bus");
            Console.WriteLine("1.to select car");
            Console.WriteLine("2.to select bicycle");

            int key = int.Parse(Console.ReadLine());

            Ivehicle vehicle = null;

            switch(key)
            {
                case 0:
                   vehicle = new Bus();
                    break;
                case 1:
                   vehicle = new Car();
                    break;
                case 2:
                   vehicle  = new Bicycle();
                    break;
                default:
                    Console.WriteLine("this vehicle doesn't exist...");
                    break;
            }


            Console.WriteLine($"Managing a {vehicle.vehicleType} (Fuel: {vehicle.fuel}):");

            vehicle.start();

            if (vehicle is IDrivable drivableVehicle)
            {
                drivableVehicle.accelerate();
            }
           vehicle.stop();













        }
    }





}