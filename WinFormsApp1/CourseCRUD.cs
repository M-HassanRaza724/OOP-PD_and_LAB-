using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class CourseCRUD
    {
        public static void AddCourse(Course c)
        {
            string query = $"INSERT INTO Courses (course_name, course_type, credit_hours, contact_hours) VALUES ('{c.course_name}', '{c.course_type}', '{c.credit_hours}', '{c.contact_hours}')";
            DatabaseHelper.ExecuteNonQuery(query);
        }
        public static void UpdateCourse(Course c)
        {
            string query = $"UPDATE Courses SET course_name = '{c.course_name}', course_type = '{c.course_type}', credit_hours = '{c.credit_hours}', contact_hours = '{c.contact_hours}' WHERE course_id = '{c.course_id}'";
            DatabaseHelper.ExecuteNonQuery(query);
        }
        public static void DeleteCourse(Course c)
        {
            string query = $"DELETE FROM Courses WHERE course_id = '{c.course_id}'";
            DatabaseHelper.ExecuteNonQuery(query);
        }
        public static Course GetCourse(int course_id)
        {
            string query = $"SELECT * FROM Courses WHERE course_id = '{course_id}'";
            MySqlDataReader reader = DatabaseHelper.ExecuteReader(query);
            if (reader.Read())
            {
                return new Course(reader["course_name"].ToString(), Convert.ToInt32(reader["credit_hours"]), Convert.ToInt32(reader["contact_hours"]), reader["course_type"].ToString());
            }
            return null;
        }
        public static List<Course> GetAllCourses(string course_name = null)
        {
            List<Course> courses = new List<Course>();
            string query = "SELECT * FROM Courses";
            MySqlDataReader reader = DatabaseHelper.ExecuteReader(query);
            int i = 0;
            while (reader.Read())
            {
                courses.Add(new Course(reader["course_name"].ToString(), Convert.ToInt32(reader["credit_hours"]), Convert.ToInt32(reader["contact_hours"]), reader["course_type"].ToString()));
                i++;
            }
            MessageBox.Show($"Data Loaded Successfully. {i} rows returned");
            return courses;
        }
    }
}
