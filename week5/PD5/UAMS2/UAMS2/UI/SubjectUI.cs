using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS2
{
    class SubjectUI
    {
        public static Subject TakeInputForSubject()
        {
            string code, type;
            int creditHour, subjectfee;
            Console.Write("Enter Subject code: ");
            code = Console.ReadLine();
            Console.Write(" Enter subject type:");
            type = Console.ReadLine();
            Console.Write(" Enter subject creditHour:");
            creditHour = int.Parse(Console.ReadLine());
            Console.Write(" Enter subject subjectfee:");
            subjectfee = int.Parse(Console.ReadLine());
            Subject sub = new Subject(code, type, creditHour, subjectfee);
            return sub;
        }
    }
}
