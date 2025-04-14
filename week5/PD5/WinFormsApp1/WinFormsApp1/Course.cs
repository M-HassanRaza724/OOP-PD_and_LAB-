using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Course
    {
        public int course_id;
        public string course_name;
        public string course_type;
        public int credit_hours;
        public int contact_hours;
        public Course( string course_name, int credit_hours, int contact_hours, string course_type = "Theory", int course_id = 0)
        {
            if (course_id != 0)
                this.course_id = course_id;
            this.course_name = course_name;
            this.course_type = course_type;
            this.credit_hours = credit_hours;
            this.contact_hours = contact_hours;
        }
    }
    }
