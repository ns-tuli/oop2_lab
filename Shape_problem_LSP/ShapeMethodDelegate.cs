using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_problem_LSP
{
    public class ShapeMethodDelegate
    {
        IShape shape;
        public ShapeMethodDelegate(IShape shape) { this.shape = shape; }
        public double areaDelegate(IShape shape)
        {    
            return shape.area();
            
        }

        public  void drawDelegate(IShape shape)
        {
            shape.draw();

        }


    }

}

        




