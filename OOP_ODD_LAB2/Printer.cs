using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODD_LAB2
{   

    public  abstract class Printer
    {
        public string content;
        public bool isColor;
        public bool isDoubleSided;
        public PageType pageType;

        public Printer(string content, bool isColor, bool isDoubleSided, PageType pageType)
        {   this.content = content;
            this.isColor = isColor;
            this.isDoubleSided = isDoubleSided;
            this.pageType = pageType;
        }
    }
}
