using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.UI
{
    class ConsoleUtility
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
        public static void Print(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void PrintError(string message)
        {
            Print(message, ConsoleColor.Red);
        }
        public static void PrintSuccess(string message)
        {
            Print(message, ConsoleColor.Green);
        }
    }
}
