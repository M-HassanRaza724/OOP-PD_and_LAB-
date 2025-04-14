using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge4.BL;

namespace Challenge4.UI
{
    class AccountUI
    {
        public static Account InputAccount()
        {
            Console.Write("Enter Account No: ");
            int accountNo = int.Parse(Console.ReadLine());
            Console.Write("Enter Account Name: ");
            string accountName = Console.ReadLine();
            Console.Write("Enter Balance: ");
            double balance = double.Parse(Console.ReadLine());
            return new Account(accountNo, accountName, balance);
        }
        public static void DisplayAccount(Account account)
        {
            Console.WriteLine("Account No: " + account.GetAccountNo());
            Console.WriteLine("Account Name: " + account.GetAccountName());
            Console.WriteLine("Balance: " + account.GetBalance());
        }
        public static void DisplayAccounts(List<Account> accounts)
        {
            foreach (Account account in accounts)
            {
                DisplayAccount(account);
            }
        }
    }
}
