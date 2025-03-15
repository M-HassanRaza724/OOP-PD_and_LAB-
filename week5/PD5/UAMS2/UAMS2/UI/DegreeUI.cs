using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS2
{
    class DegreeUI
    {
        public static void ViewDegreePrograms()
        {
            foreach (Degree d in DegreeDL.programList)
            {
                Console.WriteLine($"{d.degreeName}");
            }
        }
    }
}
