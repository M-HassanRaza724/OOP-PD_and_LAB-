using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    class Cat : Mammal
    {
        public Cat(string name) : base(name)
        {
        }
        public override string ToString()
        {
            return $"Cat[{base.ToString()}]";
        }
        public override void Greet()
        {
            Console.WriteLine("Meow");
        }
    }
}
