using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_problem_LSP
{
    public class Square:IShape
    {   
        public double side { get;set; }

        public Square(double side) 
        {   
            this.side = side;
        
        }
        public double area()
        { return side * side; }

        public void draw()
        {
            Console.WriteLine("drawing a square");
        }
    }
}
