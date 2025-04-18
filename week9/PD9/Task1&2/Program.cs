using System.ComponentModel.Design;
using Task1.BL;
using Task1.DL;
using Task1.UI;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Project p1 = new Project("Project1", 
                new Course[4]
                {
                    new AbsoluteGradedCourse("OOP", 87),
                    new AbsoluteGradedCourse("DSA", 97),
                    new GradedCourse("DBMS", 45),
                    new GradedCourse("OS", 76)
                }
            );
            Project p2 = new Project("Project2",
                 new Course[4]
                 {
                    new AbsoluteGradedCourse("SoftwareEngineering", 87),
                    new AbsoluteGradedCourse("ResearchMethods", 97),
                    new GradedCourse("LiteratureReview", 45),
                    new GradedCourse("StatisticalAnalysis", 76)
                 }
             );
            //CourseUI.ShowCourse(new GradedCourse("OS", 76));
            ProjectCRUD.AddProject(p1);
            ProjectCRUD.AddProject(p2);
            int choice = ConsoleUtility.Menu();
            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        ProjectCRUD.AddProject(ProjectUI.InputProject());
                        break;
                    case 2:
                        ProjectCRUD.DeleteProject(ProjectUI.SearchProject());
                        break;
                    case 3:
                        ProjectUI.SearchProject();
                        break;
                    case 4:
                        ProjectUI.ShowAllProject(ProjectCRUD.GetAllProjects());
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                choice = ConsoleUtility.Menu();
            }
        }
    }
}


