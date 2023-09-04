using OOP_LAB4_TASK1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB4_TASK1
{
     public class MOTOR_BIKE : Ivehicle
    {
        public int distanceKM;
        public int timeMinutes;
        public int numberOfPassengers;

        public MOTOR_BIKE(int distanceKM, int timeMinutes, int numberOfPassengers)
        {
            this.distanceKM = distanceKM;
            this.timeMinutes = timeMinutes;
            this.numberOfPassengers = numberOfPassengers;

            canTakeTrip();
            perHeadFare();
        }
        public int perHeadFare()
        {
            int fare = -1;

            fare = fare = Math.Max(25, distanceKM * 20) / numberOfPassengers;
            fare = fare - (fare % 5);
            Console.WriteLine("the fare for motor bike is " + fare);

            return fare;
        }
        public bool canTakeTrip()
        {
            bool flag = false; ;
            if (numberOfPassengers < 1)
                flag = false;
            else flag = numberOfPassengers <= 1 && distanceKM <= 10;
            Console.WriteLine("can you take the bike trip?" + flag);

            return flag;
        }
    }
}
