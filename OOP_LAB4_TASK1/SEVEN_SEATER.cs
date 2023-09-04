using OOP_LAB4_TASK1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_LAB4_TASK1

{
    public class SEVEN_SEATER : Ivehicle
    {
        public int distanceKM;
        public int timeMinutes;
        public int numberOfPassengers;

        public SEVEN_SEATER(int distanceKM, int timeMinutes, int numberOfPassengers)
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

            if (distanceKM < 10)
                fare = 300 / numberOfPassengers;
            else
                fare = distanceKM * 30 / numberOfPassengers;

            fare = fare - (fare % 5);

            Console.WriteLine("the fare for seven seater is " + fare);

            return fare;
        }
        public bool canTakeTrip()
        {
            bool flag = false;
            if (numberOfPassengers < 1)
                flag = false;

            else flag = numberOfPassengers <= 7 && distanceKM >= 10;

            Console.WriteLine("can you take the seven setaer trip?" + flag);

            return flag;
        }
    }
}

