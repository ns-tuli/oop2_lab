using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_problem_LSP
{
    public class Circle:IShape
    {   
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double area()
        { return Math.PI*radius*radius; }

        public void draw()
        {
            Console.WriteLine("drawing a circle");
        }
    }
}
