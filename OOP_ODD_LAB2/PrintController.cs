using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODD_LAB2
{
    public class PrintController           //delegate class-> who does the print work 
    {
        public void PrintDocument(string content, IPrinter printer)       //delegate function-> calls the print function to do the work
        {
                                                            
                                                            // You can delegate the print task to the selected printer
                                                            // by calling the Print method on the printer object.
            printer.Print();
        }
    }
}

