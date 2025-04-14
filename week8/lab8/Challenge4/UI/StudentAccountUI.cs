using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge4.BL;

namespace Challenge4.UI
{
    class StudentAccountUI
    {
        public static StudentAccount InputAccount()
        {
            Console.Write("Enter Account No: ");
            int accountNo = int.Parse(Console.ReadLine());
            Console.Write("Enter Account Name: ");
            string accountName = Console.ReadLine();
            Console.Write("Enter Balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Enter Institute name: ");
            string institute  = Console.ReadLine();
            Console.Write("Enter Study duration: ");
            string studyDuration = Console.ReadLine();

            return new StudentAccount(accountNo, accountName, balance, institute,studyDuration);
        }
        public static void DisplayAccount(StudentAccount account)
        {
            Console.WriteLine("Account No: " + account.GetAccountNo());
            Console.WriteLine("Account Name: " + account.GetAccountName());
            Console.WriteLine("Balance: " + account.GetBalance());
            Console.WriteLine("Institute: " + account.GetInstituteName());
            Console.WriteLine("Study duration: " + account.GetStudyDuration());
        }
        public static void DisplayAccounts(List<StudentAccount> accounts)
        {
            foreach (StudentAccount account in accounts)
            {
                DisplayAccount(account);
            }
        }
    }
}
