using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Challenge4.BL;
using System.Threading.Tasks;

namespace Challenge4.UI
{
    class SalaryAccountUI
    {
        public static SalaryAccount InputAccount()
        {
            Console.Write("Enter Account No: ");
            int accountNo = int.Parse(Console.ReadLine());
            Console.Write("Enter Account Name: ");
            string accountName = Console.ReadLine();
            Console.Write("Enter Balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine());

            return new SalaryAccount(accountNo, accountName, balance, salary);
        }
        public static void DisplayAccount(SalaryAccount account)
        {
            Console.WriteLine("Account No: " + account.GetAccountNo());
            Console.WriteLine("Account Name: " + account.GetAccountName());
            Console.WriteLine("Balance: " + account.GetBalance());
            Console.WriteLine("Salary: " + account.GetSalary());
        }
        public static void DisplayAccounts(List<SalaryAccount> accounts)
        {
            foreach (SalaryAccount account in accounts)
            {
                DisplayAccount(account);
            }
        }
    }
}
