using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    class Staff : Person
    {
        private string School;
        private double Pay;
        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            School = school;
            Pay = pay;
        }
        public override string ToString()
        {
            string person = base.ToString();
            return $"Staff[{person}, School={School}, Pay={Pay}]";
        }
        public string GetSchool()
        {
            return School;
        }
        public double GetPay()
        {
            return Pay;
        }
        public void SetSchool(string school)
        {
            School = school;
        }
        public void SetPay(double pay)
        {
            Pay = pay;
        }
    }
}
