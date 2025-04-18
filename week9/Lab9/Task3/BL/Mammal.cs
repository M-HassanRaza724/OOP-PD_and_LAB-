using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    class Mammal : Animal
    {
        public Mammal(string name) : base(name)
        {
        }
        public override string ToString()
        {
            return $"Mammal[{base.ToString()}]";
        }
        public virtual void Greet()
        {
            Console.WriteLine($"Hello, I am a mammal named {Name}.");
        }
    }
}
