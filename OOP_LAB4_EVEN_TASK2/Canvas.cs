using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB4_EVEN_TASK2
{   
    //define the canvas class to draw a list of shape
    public class Canvas
    {
        public List<IShape> shapes;

        public Canvas()
        {   
            shapes = new List<IShape>();     //when we create an instance of canvas a new list will be created
        }

        public void AddShape(IShape shape)
        {   
            shapes.Add(shape);              //AddShape method to add shape to the list
        }

        public void DrawShapes()
        {
            foreach (IShape shape in shapes)
            {   
                shape.Draw();
            }
        }


    }
}
