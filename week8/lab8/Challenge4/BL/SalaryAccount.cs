using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4.BL
{
    class SalaryAccount : Account
    {
        double Salary;

        public SalaryAccount(int accountNo, string accountName, double balance, double salary) : base(accountNo, accountName, balance)
        {
            Salary = salary;
        }
        public double GetSalary()
        {
            return Salary;
        }
        public void SetSalary(double salary)
        {
            Salary = salary;
        }
    }
}
