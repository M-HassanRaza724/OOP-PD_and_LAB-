using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    class Course
    {
        protected string Coursename;
        protected double Marks;
        public Course(string coursename, double marks)
        {
            Coursename = coursename;
            Marks = marks;
        }

        public string GetCourseName()
        {
            return Coursename;
        }
        public double GetMarks()
        {
            return Marks;
        }
        public void SetMarks(double marks)
        {
            Marks = marks;
        }
        public void SetCourseName(string coursename)
        {
            Coursename = coursename;
        }

        public virtual bool Pass()
        {
            return false;
        }
        public virtual bool CalculateGrade(double percentage)
        {
            return false;
        }
    }
}
