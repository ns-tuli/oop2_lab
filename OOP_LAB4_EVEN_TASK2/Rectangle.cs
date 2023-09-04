using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB4_EVEN_TASK2
{
    public class Rectangle:IShape
    {
        public double x, y, length, width;

        public Rectangle(double x, double y, double length, double width)
        {
            this.x = x;
            this.y = y;
            this.length = length;
            this.width = width;
        }

        public double CalculateArea()
        {
            return length * width;

        }

        public void Draw()
        {
            Console.WriteLine($"drawing rectangle at ({x},{y}) with length {length} and width {width}");
        }

    }
}
