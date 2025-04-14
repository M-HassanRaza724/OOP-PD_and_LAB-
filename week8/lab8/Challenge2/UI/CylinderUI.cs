using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge2.BL;

namespace Challenge2.UI
{
    class CylinderUI
    {
        public static void ToString(Cylinder cylinder)
        {
            Console.WriteLine($"Cylinder[Radius: {cylinder.GetRadius()},Color = {cylinder.GetColor()}, Height = {cylinder.GetHeight()}]");
        }

        public static void ShowAllCylinders(List<Cylinder> cylinders)
        {
            if (cylinders.Count == 0)
            {
                Console.WriteLine("No Cylinders Found");
            }
            else
            {
                foreach (Cylinder cylinder in cylinders)
                {
                    ToString(cylinder);
                }
            }
        }
        public static Cylinder AddCylinder()
        {
            Console.WriteLine("Enter Cylinder Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Cylinder Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Cylinder Color: ");
            string color = Console.ReadLine();
            Cylinder cylinder = new Cylinder(radius, height, color);
            return cylinder;
        }
        public static int Menu()
        {
            Console.WriteLine("1. Add Cylinder");
            Console.WriteLine("2. Show All Cylinders");
            Console.WriteLine("3. MainMenu");
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}

