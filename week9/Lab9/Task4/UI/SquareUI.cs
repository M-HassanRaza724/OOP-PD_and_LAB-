using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.BL;

namespace Task4.UI
{
    class SquareUI
    {
        public static Square InputSquare()
        {
            Console.Write("Enter the side of the square:");
            double side = Convert.ToDouble(Console.ReadLine());
            return new Square(side);
        }
        //public static void PrintArea(Square square)
        //{
        //    Console.WriteLine("The shape is square and area is: " + square.CalculateArea());
        //}
    }
}
