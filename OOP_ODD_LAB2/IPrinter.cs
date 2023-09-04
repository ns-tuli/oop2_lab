using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODD_LAB2
{   
    public enum PageType
    {
        A3,
        A4,
        LetterPage
    }
    public interface IPrinter
    {   
        void Print();
    }
}
