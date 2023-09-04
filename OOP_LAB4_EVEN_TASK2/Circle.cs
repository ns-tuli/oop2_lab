using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB4_EVEN_TASK2
{
    public class Circle:IShape
    {
        public double x, y, radius;

        public Circle(double x, double y, double radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public void Draw()
        {
            Console.WriteLine($"drawing circle with center ({x},{y}) and radius {radius}");
        }
    }
}
