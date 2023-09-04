using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB4_TASK2
{
    public class Others:Movie, Icalculate
    {

        public Others( Genre genre, DateTime releaseDate, int duration):base( genre,  releaseDate,  duration)
        {
           
            this.Genre = genre;
            this.release_date = releaseDate;
            this.duration = duration;
        }

        public  double calculate_price()
        {
            return 100; // No discount for Other
        }
    }
}
