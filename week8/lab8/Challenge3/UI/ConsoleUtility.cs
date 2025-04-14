using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3.UI
{
    class ConsoleUtility
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static int MainMenu()
        {
            Console.WriteLine("         Main Menu      ");
            Console.WriteLine("1. Person Management");
            Console.WriteLine("2. Staff Management");
            Console.WriteLine("3. Student Management");
            Console.Write("Enter your choice: ");

            return int.Parse(Console.ReadLine());
        }
        
        public string EntitySearch(string entityName)
        {
            Console.Write($"Enter {entityName} name: ");
            return Console.ReadLine();
        }
    }
}
