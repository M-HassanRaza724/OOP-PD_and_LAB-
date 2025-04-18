using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.BL;

namespace Task4.UI
{
    class RectangleUI
    {
        public static Rectangle InputRectangle()
        {
            Console.Write("Enter the height of the rectangle:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width of the rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());
            return new Rectangle(height,width);
        }
    }
}
