using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace Task2.UI
{
    class PersonUI
    {
        public static void PrintPerson(Person person)
        {
            Console.WriteLine(person.ToString());
        }
        public static void PrintPersonList(List<Person> personList)
        {
            foreach (var person in personList)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
