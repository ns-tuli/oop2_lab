using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB4_TASK2
{
    public class Thriller : Movie, Icalculate
    {
        public Thriller( Genre genre, DateTime releaseDate, int duration):base( genre,releaseDate,duration)
        {
           
            this.Genre = genre;
            this.release_date = releaseDate;
            this.duration = duration;
        }
    

        public double calculate_price()
        {
            double basePrice = 100;
            double price = basePrice;

            if ((DateTime.Now.Year - release_date.Year) > 5)
            {
                return price * 0.6375 ;   // Additional 10% discount for old Thriller
            }

            return price * 0.85; // 15% discount for Thriller
        }
    }
}
