using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL

namespace Challenge1.DL
{
    class BicycleCRUD
    {
        public static List<Bicycle> bicycles = new List<Bicycle>();
        public static void AddBicycle(Bicycle bicycle)
        {
            bicycles.Add(bicycle);
        }
        public static List<Bicycle> GetBicycles()
        {
            return bicycles;
        }
    }
}
