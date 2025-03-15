using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS2
{
    public class StudentDL
    {
        public static List<Student> studentList = new List<Student>();

        public static void AddIntoStudentList(Student s)
        {
            StudentDL.studentList.Add(s);
        }
        public static List<Student> SortStudentByMerit()
        {
            List<Student> sortedStuList = new List<Student>();
            foreach (Student stu in StudentDL.studentList)
                stu.CalculateMerit();
            sortedStuList = StudentDL.studentList.OrderByDescending(o => o.merit).ToList();
            return sortedStuList;
        }
    }
}
