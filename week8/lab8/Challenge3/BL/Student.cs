using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3.BL
{
    class Student : Person
    {
        string Program;
        int Year;
        double Fee;

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public new string ToString()
        {
            string person = base.ToString();
            return $"Student[{person}, Program={Program}, Year={Year}, Fee={Fee}]";
        }
        public string GetProgram()
        {
            return Program;
        }
        public int GetYear()
        {
            return Year;
        }
        public double GetFee()
        {
            return Fee;
        }
        public void SetProgram(string program)
        {
            Program = program;
        }
        public void SetYear(int year)
        {
            Year = year;
        }
        public void SetFee(double fee)
        {
            Fee = fee;
        }
    }
}
