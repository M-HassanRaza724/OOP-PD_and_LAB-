using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.UI
{
    class CourseUI
    {
        public static Course InputCourses()
        {
            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Course Marks: ");
            double marks = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Course Type (1 for Absolute, 2 for Graded): ");
            int type = Convert.ToInt32(Console.ReadLine());
            if(type == 1)
            {
                return new AbsoluteGradedCourse(name, marks);
            }
            else if(type == 2)
            {
                return new GradedCourse(name, marks);
            }
            else
            {
                throw new Exception("Invalid Course Type");
            }
        }
        public static void ShowCourse(Course c)
        {
            Console.WriteLine($"Course name: {c.GetCourseName()}");
            Console.WriteLine($"Course Marks: {c.GetMarks()}");
            if (c.Pass())
                Console.WriteLine($"Status: Pass");
            else
                Console.WriteLine($"Status: Fail");
        }
        public static void ShowCourseList(Course[] courses)
        {
            foreach (var course in courses)
            {
                ShowCourse(course);
                Console.WriteLine();
            }
        }
    }
}
