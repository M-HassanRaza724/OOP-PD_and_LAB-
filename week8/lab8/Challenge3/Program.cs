using Challenge3.BL;
using System;
using Challenge3.UI;

namespace Challenge3
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student("John Doe", "123 Main St", "Computer Science", 2, 15000);


            ConsoleUtility.PrintMessage("\n\nStudent Details:");
            Console.WriteLine(student.ToString());

            student.SetAddress(student.GetAddress() + ", Apt 4B");
            student.SetProgram("Software Engineering");

            ConsoleUtility.PrintMessage("Student Details after changes:");
            Console.WriteLine(student.ToString());
            ConsoleUtility.PrintMessage("\n\n");


            Staff staff = new Staff("Jane Smith", "456 Elm St", "Oxford Grammer", 60000);
            ConsoleUtility.PrintMessage("Staff details: ");
            Console.WriteLine(staff.ToString());

            staff.SetAddress("200 Elm St");
            staff.SetPay(600);

            ConsoleUtility.PrintMessage("Staff details after changes: ");
            Console.WriteLine(staff.ToString());
        }
    }
}