using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.DL;

namespace Task1.UI
{
    class ProjectUI
    {
        public static Project InputProject()
        {
            Console.Write("Enter Project name: ");
            string name = Console.ReadLine();
            Course[] courses = new Course[4];  
            for(int i = 0;i < 4;i++)
            {
                Console.WriteLine($"Enter Course {i + 1} details:");
                courses[i] = CourseUI.InputCourses();
                Console.WriteLine("\n");
            }
            return new Project(name, courses);
        }
        public static void ShowProject(Project p)
        {
            Console.WriteLine($"Project Name {p.GetName()}");
            Console.WriteLine("Courses:\n");
            CourseUI.ShowCourseList(p.GetCourses());
            if(p.Pass())
                Console.WriteLine($"Project Status: Pass");
            else
                Console.WriteLine($"Project Status: Fail\n");
        }
        public static void ShowAllProject(List<Project> projects)
        {
            foreach (Project p in projects)
            {
                ShowProject(p);
                //Console.WriteLine("/n");
            }
        }
        public static Project SearchProject()
        {
            Console.Write("Enter project name: ");
            string name = Console.ReadLine();
            Project project = ProjectCRUD.GetProjectByName(name);
            if (project != null)
            {
                Console.WriteLine("Project found:");
                ShowProject(project);
                return project;
            }
            Console.WriteLine("Project not found.");
            return null;    
        }
    }
}
