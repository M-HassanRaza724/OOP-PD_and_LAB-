using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS2
{
    public class ConsoleUtility
    {
        public static int Menu()
        {
            Console.WriteLine("1. add students.");
            Console.WriteLine("2. Add degree program.");
            Console.WriteLine("3. Generate Merit.");
            Console.WriteLine("4. View registered students.");
            Console.WriteLine("5. view students of a specific program.");
            Console.WriteLine("6. Register Subject for a specific Student");
            Console.WriteLine("7. calculate Fees for all Students.");
            Console.WriteLine("8. Exit.");
            Console.Write("Enter your choice: ");
            return int.Parse(Console.ReadLine());
        }

        public static void Header()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("                  UAMS                  ");
            Console.WriteLine("****************************************");
        }


        public static void clearScreen()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
