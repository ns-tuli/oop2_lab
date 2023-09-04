using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB4_TASK1

{
    public class SEDAN:Ivehicle
    {
        public int distanceKM;
        public int timeMinutes;
        public int numberOfPassengers;
         
        public SEDAN(int distanceKM, int timeMinutes,int numberOfPassengers)
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

            fare = (50 + 30 * distanceKM + timeMinutes / 2) / numberOfPassengers;
            fare= fare-(fare%5);
            Console.WriteLine("the fare for sevan is " + fare);
            return fare;
        

    }
        public bool canTakeTrip()
        {
            bool flag = false;
            if (numberOfPassengers < 1)
              flag=false;
            else flag= numberOfPassengers <= 4 && distanceKM <= 25;

            Console.WriteLine("can you take the sevan trip ? " + flag);

            return flag;
        }
    }
}
