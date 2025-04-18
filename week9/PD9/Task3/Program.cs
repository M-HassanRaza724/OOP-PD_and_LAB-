using Task3.BL;
//using Task3.DL;
using Task3.UI;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Static Polymorphism Task3
            InterestUI.PrintInterest("normal", new Interest().TrueBank(5000, 0.1));
            InterestUI.PrintInterest("prime", new Interest().TrueBank(5000, 0.1, "prime"));
            Console.WriteLine("\n--------------------------------------------------\n");


            // Dynamic Polymorphism Task4
            InterestUI.PrintInterest("normal", new Interest().TrueBank(5000, 0.1));
            InterestUI.PrintInterest("simple", new SimpleInterest().TrueBank(5000, 0.1));
            InterestUI.PrintInterest("fixed", new FixedInterest().TrueBank(5000, 0.1));
        }
    }
}