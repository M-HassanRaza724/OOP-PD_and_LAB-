using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge4.BL;

namespace Challenge4.DL
{
    class SavingAccountCRUD
    {
        public static List<SavingAccount> savingAccounts = new List<SavingAccount>();
        public static void AddSavingAccount(SavingAccount savingAccount)
        {
            savingAccounts.Add(savingAccount);
        }
        public static void DeleteSavingAccount(int savingAccountNo)
        {
            foreach (SavingAccount savingAccount in savingAccounts)
            {
                if (savingAccount.GetAccountNo() == savingAccountNo)
                {
                    savingAccounts.Remove(savingAccount);
                    break;
                }
            }
        }
        public static SavingAccount GetSavingAccount(int savingAccountNo)
        {
            foreach (SavingAccount savingAccount in savingAccounts)
            {
                if (savingAccount.GetAccountNo() == savingAccountNo)
                {
                    return savingAccount;
                }
            }
            return null;
        }
        public static List<SavingAccount> GetAllSavingAccounts()
        {
            return savingAccounts;
        }
    }
}
