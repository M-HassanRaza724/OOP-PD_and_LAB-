using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class CustomerUI
    {
        public static int CustomerMenu()
        {
            Console.WriteLine("1● View All Product.");
            Console.WriteLine("2● Buy Products.");
            Console.WriteLine("3● Generate Invoice.");
            Console.WriteLine("4● Veiw Profile.");
            Console.WriteLine("5● Exit.");
            Console.Write("Enter Your choice: ");
            return int.Parse(Console.ReadLine());
        }
        public static void ViewInvoice(float invoice)
        {
            Console.WriteLine($"Total Invoice is {invoice}");
        }

    }
}
