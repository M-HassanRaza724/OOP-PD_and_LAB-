using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.BL;

namespace Task3.DL
{
    class MammalCRUD
    {
        public static List<Mammal> mammals = new List<Mammal>();
        public static void AddMammal(Mammal mammal)
        {
            mammals.Add(mammal);
        }
    }
}
