using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;

namespace Challenge1.UI
{
    class BicycleUI
    {
        public void ShowBicycle(Bicycle bicycle)
        {
            Console.WriteLine("Bicycle Details:");
            Console.WriteLine($"Cadence: {bicycle.GetCadence()}");
            Console.WriteLine($"Gear: {bicycle.GetGear()}");
            Console.WriteLine($"Speed: {bicycle.GetSpeed()}");
        }
        public Bicycle AddBicycle()
        {
            Console.WriteLine("Enter Cadence:");
            int cadence = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Gear:");
            int gear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Speed:");
            int speed = Convert.ToInt32(Console.ReadLine());
            return new Bicycle(cadence, gear, speed);
        }
        public void ShowBicycles(List<Bicycle> bicycles)
        {
            Console.WriteLine("Bicycles List:");
            foreach (var bicycle in bicycles)
            {
                ShowBicycle(bicycle);
            }
        }
        public int InputIncrement()
        {
            Console.Write("Enter increment value:");
            int increment = Convert.ToInt32(Console.ReadLine());
            return increment;
        }
        public int InputDecrement()
        {
            Console.Write("Enter decrement value:");
            int decrement = Convert.ToInt32(Console.ReadLine());
            return decrement;
        }

    }
}
