using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge4.BL;

namespace Challenge4.DL
{
    class SalarySalaryAccountCRUD
    {
        public static List<SalaryAccount> salaryAccounts = new List<SalaryAccount>();
        public static void AddSalaryAccount(SalaryAccount salaryAccount)
        {
            salaryAccounts.Add(salaryAccount);
        }
        public static void DeleteSalaryAccount(int salaryAccountNo)
        {
            foreach (SalaryAccount salaryAccount in salaryAccounts)
            {
                if (salaryAccount.GetAccountNo() == salaryAccountNo)
                {
                    salaryAccounts.Remove(salaryAccount);
                    break;
                }
            }
        }
        public static SalaryAccount GetSalaryAccount(int salaryAccountNo)
        {
            foreach (SalaryAccount salaryAccount in salaryAccounts)
            {
                if (salaryAccount.GetAccountNo() == salaryAccountNo)
                {
                    return salaryAccount;
                }
            }
            return null;
        }
        public static List<SalaryAccount> GetAllSalaryAccounts()
        {
            return salaryAccounts;
        }
    }
}
