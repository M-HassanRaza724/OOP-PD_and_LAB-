using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge4.BL;

namespace Challenge4.DL
{
    class AccountCRUD
    {
        public static List<Account> accounts = new List<Account>();
        public static void AddAccount(Account account)
        {
            accounts.Add(account);
        }
        public static void DeleteAccount(int accountNo)
        {
            foreach(Account account in accounts)
            {
                if(account.GetAccountNo() == accountNo)
                {
                    accounts.Remove(account);
                    break;
                }
            }
        }
        public static Account GetAccount(int accountNo)
        {
            foreach (Account account in accounts)
            {
                if (account.GetAccountNo() == accountNo)
                {
                    return account;
                }
            }
            return null;
        }
        public static List<Account> GetAllAccounts()
        {
            return accounts;
        }
    }
}
