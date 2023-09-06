using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_problem_LSP
{   
    public enum ShapeType
    {
        Rectangle,
        Square,
        Circle
    }

    public class Program
    {   
        static void Main(string[] args)
        {
            

            Console.WriteLine("press a number to continue");
            Console.WriteLine("press 0 for rectangle");
            Console.WriteLine("press 1 for square");
            Console.WriteLine("press 2 for circle");


            int number=Convert.ToInt32(Console.ReadLine());


            switch (number) 
            {
                case 0:
                    {
                        IShape rectangle = new Rectangle(5, 10);
                        ShapeMethodDelegate del = new ShapeMethodDelegate(rectangle);

                        Console.WriteLine( "area for ractangle is ");
                        Console.WriteLine(Convert.ToDouble(del.areaDelegate(rectangle)));

                        del.drawDelegate(rectangle);
                        break;
                    }

                case 1:
                    {
                        IShape square = new Square(5);
                        ShapeMethodDelegate del = new ShapeMethodDelegate(square);
                        Console.WriteLine("area for square is ");
                        Console.WriteLine(Convert.ToDouble(del.areaDelegate(square)));
                        del.drawDelegate(square);
                        break;
                    }
                    case 2:
                    {
                        IShape circle = new Circle(5);
                        ShapeMethodDelegate del = new ShapeMethodDelegate(circle);
                        Console.WriteLine("area for circle is ");
                        Console.WriteLine(Convert.ToDouble(del.areaDelegate(circle)));
                        del.drawDelegate(circle);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid number");
                        break;
                    }




            }

        }

    }
}
