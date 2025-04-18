using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.UI
{
    class InterestUI
    {
        public static void PrintInterest(string interestType,double interest)
        {
            Console.WriteLine($"The {interestType} interest for a holder: ${interest}");
        }
    }
}
