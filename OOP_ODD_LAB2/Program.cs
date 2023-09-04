using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODD_LAB2
{
    public class Program
    {
        static void Main(string[] args)
        {

            PrintController printController = new PrintController();          //delegate function 

            string document = "This is a sample document.";             //sample for content



            //creating object for epson printer and then call the delegate function for printing

            IPrinter epson = new EpsonPrinter(document, false, true, PageType.A4);
            Console.WriteLine("Printing with Epson Printer:");
            printController.PrintDocument(document, epson);       //delegate function e object epson pass kore dilam for printing
            Console.WriteLine();

            //creating object for cannon printer and call the delegate function for printing

            IPrinter canon = new CanonPrinter(document,true,false,PageType.A3);
            Console.WriteLine("Printing with Canon Printer:");
            printController.PrintDocument(document, canon);       //delegate function e object cannon pass kore dilam to print
            Console.WriteLine();


        }

    }
}

