using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    class Interest
    {
        public virtual double TrueBank(double amount, double rate)
        {
            return amount + (amount * rate);
        }
        public double TrueBank(double amount, double rate, string holderType)
        {
            if ( holderType == "prime")
            {
                return amount + (amount * rate) + 2000;
            }
            else return TrueBank(amount, rate);
        }
    }
}
