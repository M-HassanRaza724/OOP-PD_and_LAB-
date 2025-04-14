using Challenge3.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3.DL
{
    class StudentCRUD
    {
        public static List<Student> students = new List<Student>();

        public static void AddStudent(Student student)
        {
            students.Add(student);
        }
        public static void DeleteStudent(string name)
        {
            foreach (Student student in students)
            {
                if (student.GetName() == name)
                {
                    students.Remove(student);
                    break;
                }
            }
        }
        public static Student GetStudent(string name)
        {
            foreach (Student p in students)
            {
                if (p.GetName() == name)
                {
                    return p;
                }
            }
            return null;
        }
        public List<Student> GetAllStudents()
        {
            return students;
        }
    }
}
