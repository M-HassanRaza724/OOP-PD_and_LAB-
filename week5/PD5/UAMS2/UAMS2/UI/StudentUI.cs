using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS2
{
    public class StudentUI
    {
        public static void printstudents()
        {
            foreach (Student s in StudentDL.studentList)
            {
                if (s.regDegree != null)
                    Console.WriteLine($"{s.name} got admission in {s.regDegree}");
                else
                    Console.WriteLine($"{s.name} did not get admission");
            }
        }
    }
}
