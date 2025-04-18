using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.DL
{
    class ProjectCRUD
    {
        public static List<Project> projects = new List<Project>();

        public static void AddProject(Project project)
        {
            projects.Add(project);
        }
        public static void DeleteProject(Project project)
        {
            projects.Remove(project);
        }
        public static Project GetProjectByName(string name)
        {
            foreach (Project project in projects)
            {
                if (project.GetName() == name)
                {
                    return project;
                }
            }
            return new Project(name);
        }
        public static List<Project> GetAllProjects() { return projects; }
    }
}
