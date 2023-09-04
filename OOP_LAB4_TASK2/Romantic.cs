using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB4_TASK2
{
     class Romantic : Movie,Icalculate
    {

        public Romantic(Genre genre, DateTime releaseDate, int duration):base( genre,  releaseDate, duration)
        {
            
            this.Genre = genre;
            this.release_date = releaseDate;
            this.duration = duration;
        }
        public  double calculate_price()
        {
            double basePrice = 100;
            return basePrice * 0.7; // 30% discount for Romantic
        }
    }
}
