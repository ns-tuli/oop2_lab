using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_problem_LSP
{
    public class Rectangle:IShape
    {   
        public double length { get; set; }
        public double width { get; set; }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;

        }
        public double area()
        { 
            return length*width;
        }
        public void draw()
        {
            Console.WriteLine("drawing a rectangle");
        }


    }
}
