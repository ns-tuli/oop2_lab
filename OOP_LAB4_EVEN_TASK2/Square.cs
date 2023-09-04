using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB4_EVEN_TASK2
{
    public class Square : IShape
    {
        private double x, y, sideLength;

        public Square(double x, double y, double sideLength)
        {
            this.x = x;
            this.y = y;
            this.sideLength = sideLength;
        }

        public double CalculateArea()
        {
            return Math.Pow(sideLength, 2);
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing Square at ({x}, {y}) with Side Length {sideLength}");
        }
    }


}
