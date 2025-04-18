using Task2.BL;
using Task2.UI;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Person, Student, and Staff
            Person person = new Person("JohnDoe", "S54321");
            Student student = new Student("JaneSmith", "S12345", "CS",2024,700000 );
            Staff staff = new Staff("JaneSmith", "S67890", "LGS", 50000);

            // Print details using UI classes
            PersonUI.PrintPerson(person);
            PersonUI.PrintPerson(student);
            PersonUI.PrintPerson(staff);
        }
    }
}
