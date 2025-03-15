using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    class AdminUI
    {
        static public int AdminMenu()
        {
            Console.WriteLine("1● Add Product. ");
            Console.WriteLine("2● View All Product.");
            Console.WriteLine("3● Find Product with the Highest Unit Price");
            Console.WriteLine("4● View Sales Tax of All Products.");
            Console.WriteLine("5● Products to be Ordered.");
            Console.WriteLine("6● View Profile.");
            Console.WriteLine("7● Exit.");
            Console.Write("Enter Your choice: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
