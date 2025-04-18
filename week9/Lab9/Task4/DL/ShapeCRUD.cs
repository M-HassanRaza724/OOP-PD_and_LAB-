using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.BL;

namespace Task4.DL
{
    class ShapeCRUD
    {
        public static List<Shape> shapes = new List<Shape>();

        public static void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }
        public static List<Shape> GetShapes()
        {
            return shapes;
        }
    }
}
