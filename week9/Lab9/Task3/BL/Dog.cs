using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    class Dog : Mammal
    {
        public Dog(string name) : base(name)
        {
        }
        public override string ToString()
        {
            return $"Dog[{base.ToString()}]";
        }
        public override void Greet()
        {
            Console.WriteLine("Woof");
        }
        public void Greet(Dog anotherDog)
        {
            Console.WriteLine("Woooof");

        }
    }
}
