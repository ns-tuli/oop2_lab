using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB4_TASK2
{
    public enum Genre
    {
        Horror,
        Romantic,
        Thriller,
        Other
    }
    public class Movie
    {
        
        public Genre Genre { get; set; }
        public DateTime release_date { get; set; }
        public int duration { get; set; }

        public Movie( Genre genre, DateTime release_date, int duration)
        {
           
            this.Genre = genre;
            this.release_date = release_date;
            this.duration = duration;
        }

        
        




    }
}
