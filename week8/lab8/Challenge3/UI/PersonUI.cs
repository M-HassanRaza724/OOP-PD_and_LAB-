using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge3.BL;

namespace Challenge3.UI
{
    class PersonUI
    {
        public Person InputPerson()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            return new Person(name, address);
        }
        public void PrintPerson(Person person)
        {
            Console.WriteLine(person.ToString());
        }
        public void PrintPersonList(List<Person> personList)
        {
            foreach (var person in personList)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
