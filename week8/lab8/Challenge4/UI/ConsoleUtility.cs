using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge4.BL;

namespace Challenge4.UI
{
    class ConsoleUtility
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static int MainMenu()
        {
            Console.WriteLine("         Main Menu");
            Console.WriteLine("1. Account Management");
            Console.WriteLine("2. Saving account Management");
            Console.WriteLine("3. Student account Management");
            Console.WriteLine("4. Salary account Management");
            Console.Write("Enter your choice: ");

            return int.Parse(Console.ReadLine());
        }
    }
}
