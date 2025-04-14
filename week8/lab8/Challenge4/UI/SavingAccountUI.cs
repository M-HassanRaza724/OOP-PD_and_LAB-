using Challenge4.BL;

namespace Challenge4.UI
{
    class SavingAccountUI
    {
        public static SavingAccount InputAccount()
        {
            Console.Write("Enter Account No: ");
            int accountNo = int.Parse(Console.ReadLine());
            Console.Write("Enter Account Name: ");
            string accountName = Console.ReadLine();
            Console.Write("Enter Balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Enter Interest Rate: ");
            double interestRate = double.Parse(Console.ReadLine());
            return new SavingAccount(accountNo, accountName, balance, interestRate);
        }
        public static void DisplayAccount(SavingAccount account)
        {
            Console.WriteLine("Account No: " + account.GetAccountNo());
            Console.WriteLine("Account Name: " + account.GetAccountName());
            Console.WriteLine("Balance: " + account.GetBalance());
            Console.WriteLine("Interest Rate: " + account.GetInterestRate());
            Console.WriteLine("Interest: " + account.CalculateInterest());
        }
        public static void DisplayAccounts(List<SavingAccount> accounts)
        {
            foreach(SavingAccount account in accounts)
            {
                DisplayAccount(account);
            }
        }
    }
}
