using Challenge2.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2.UI
{
    class CircleUI
    {
        public static void ToString(Circle circle)
        {
            Console.WriteLine($"Circle[Radius: {circle.GetRadius()},Color = {circle.GetColor()}]");
        }

        public static void ShowAllCircles(List<Circle> circles)
        {
            if (circles.Count == 0)
            {
                Console.WriteLine("No Circles Found");
            }
            else
            {
                foreach (Circle circle in circles)
                {
                    ToString(circle);
                }
            }
        }
        public static Circle AddCircle()
        {
            Console.WriteLine("Enter Circle Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Circle Color: ");
            string color = Console.ReadLine();
            Circle circle = new Circle(radius, color);
            return circle;
        }
        public static int Menu()
        {
            Console.WriteLine("1. Add Circle");
            Console.WriteLine("2. Show All Circles");
            Console.WriteLine("3. MainMenu");
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}
