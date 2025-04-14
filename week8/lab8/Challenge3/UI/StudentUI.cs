using Challenge3.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3.UI
{
    class StudentUI
    {
        public Student InputStudent()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter Program: ");
            string program = Console.ReadLine();
            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter Fee: ");
            double fee = double.Parse(Console.ReadLine());

            return new Student(name, address, program, year, fee);
        }
        public void PrintStudent(Student student)
        {
            Console.WriteLine(student.ToString());
        }
        public void PrintStudentList(List<Student> studentList)
        {
            foreach (var student in studentList)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
