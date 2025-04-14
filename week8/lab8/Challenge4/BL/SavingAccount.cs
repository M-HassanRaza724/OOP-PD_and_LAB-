using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Challenge4.BL
{
    class SavingAccount : Account
    {
        double InterestRate;

        public SavingAccount(int accountNo, string accountName, double balance, double interestRate) : base(accountNo, accountName, balance)
        {
            InterestRate = interestRate;
        }

        public void SetInterestRate(double interestRate)
        {
            InterestRate = interestRate;
        }
        public double GetInterestRate()
        {
            return InterestRate;
        }
        public double CalculateInterest()
        {
            return (Balance * InterestRate) / 100;
        }
        public new bool Debit(double decrement)
        {
            if (decrement < 100000)
            {
                return base.Debit(decrement);
            }
            return false;
        }
    }
}
