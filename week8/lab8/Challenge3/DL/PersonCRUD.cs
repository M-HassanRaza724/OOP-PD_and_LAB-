using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge3.BL;

namespace Challenge3.DL
{
    class PersonCRUD
    {
        public static List<Person> persons = new List<Person>();

        public static void AddPerson(Person person)
        {
            persons.Add(person);
        }
        public static void DeletePerson(string name)
        {
            foreach(Person person in persons)
            {
                if (person.GetName() == name)
                {
                    persons.Remove(person);
                    break;
                }
            }
        }
        public static Person GetPerson(string name)
        {
            foreach (Person p in persons)
            {
                if (p.GetName() == name)
                {
                    return p;
                }
            }
            return null;
        }
        public List<Person> GetAllPersons()
        {
            return persons;
        }
    }
}
