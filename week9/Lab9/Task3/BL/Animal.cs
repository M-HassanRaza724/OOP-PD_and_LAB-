using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    class Animal
    {
        protected string Name;

        public Animal(string name)
        {
            Name = name;
        }
         
        public virtual string ToString()
        {
            return $"Animal= {Name}";
        }
    }
}
