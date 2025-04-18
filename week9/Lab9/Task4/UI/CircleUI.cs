using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.BL;

namespace Task4.UI
{
    class CircleUI
    {
        public static Circle InputCircle()
        {
            Console.Write("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());
            return  new Circle(radius);
        }
        //public static void PrintArea(Circle circle)
        //{
        //    Console.WriteLine("The shape is circle and area is: " + circle.CalculateArea());
        //}
    }
}
