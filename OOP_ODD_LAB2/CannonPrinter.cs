﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODD_LAB2
{
    public class CanonPrinter :Printer, IPrinter
    {

       
        public CanonPrinter(string content, bool isColor, bool isDoubleSided, PageType pageType):base(content,isColor, isDoubleSided,pageType)
        {
            this.content = content;
            this.isColor = isColor;
            this.isDoubleSided = isDoubleSided;
            this.pageType = pageType;
        }

        public void Print()
        {

            Console.WriteLine($"Canon Printer: Printing in {(isColor ? "color" : "black and white")}");
            Console.WriteLine($"Page Type: {pageType}");
            Console.WriteLine($"Double-sided: {(isDoubleSided ? "Yes" : "No")}");
            Console.WriteLine(content);
        }
    }
}

