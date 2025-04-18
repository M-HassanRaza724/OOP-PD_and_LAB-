using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.UI
{
    public class ConsoleUtility
    {
        public static int Menu()
        {
            Console.WriteLine("1 Add Project");
            Console.WriteLine("2 Delete Project");
            Console.WriteLine("3 Search Project");
            Console.WriteLine("4 Show All Projects");
            Console.Write("Enter your choice: ");

            return Convert.ToInt32(Console.ReadLine());
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
