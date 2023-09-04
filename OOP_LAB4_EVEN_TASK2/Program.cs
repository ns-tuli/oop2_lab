using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB4_EVEN_TASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Canvas canvas = new Canvas();

            canvas.AddShape(new Circle(1,2,3));
            canvas.AddShape(new Rectangle(4, 5, 6, 9));
            canvas.AddShape(new Square(1,2,3));

            canvas.DrawShapes();
        
        }

    }


}
