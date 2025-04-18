using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    class Person
    {
        protected string Name;
        protected string Address;

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public virtual string ToString()
        {
            return $"Person[name={Name}, Address={Address}]";
        }
        public string GetName()
        {
            return Name;
        }
        public string GetAddress()
        {
            return Address;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetAddress(string address)
        {
            Address = address;
        }
    }
}
