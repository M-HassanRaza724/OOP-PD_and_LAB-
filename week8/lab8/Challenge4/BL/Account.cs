using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4.BL
{
    class Account
    {
        protected int AccountNo;
        protected string AccountName;
        protected double Balance;

        public Account(int accountNo, string accountName, double balance)
        {
            AccountNo = accountNo;
            AccountName = accountName;
            Balance = balance;
        }
        public int GetAccountNo()
        {
            return AccountNo;
        }
        public string GetAccountName()
        {
            return AccountName;
        }
        public double GetBalance()
        {
            return Balance;
        }
        public void SetAccountName(string accountName)
        {
            AccountName = accountName;
        }
        public void Credit(double increment)
        {
            Balance += increment;
        }
        public bool Debit(double decrement)
        {
            if (Balance - decrement < 0)
            {
                return false;
            }
            Balance -= decrement;
            return true;
        }
    }
}
