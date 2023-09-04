using OOP_LAB4_TASK1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System;

namespace OOP_LAB4_TASK1 {

    public  class vehicleManager
    {
        int number;
        public void vehicle()
        {

            Console.WriteLine("press a number here:");
            number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case (int)VehicleType.SEDAN :
                    {
                        Ivehicle sedan = new SEDAN(30, 20, 5);
                        return;
                    }
                case (int)VehicleType.MOTOR_BIKE:
                    {
                        Ivehicle motor = new MOTOR_BIKE(30, 20, 5);
                        return;

                    }
                case (int)VehicleType.SEVEN_SEATER:
                    {
                        Ivehicle seven_seater = new SEVEN_SEATER (20,30,7);
                        return;

                    }

                default:
                    {
                        Console.WriteLine("this vehicle is not available ^ ^ ");
                        return;
                    }

            }

        }
        







    }

}

