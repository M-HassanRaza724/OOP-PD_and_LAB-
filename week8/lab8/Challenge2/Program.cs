using Challenge2.BL;
using Challenge2.DL;
using Challenge2.UI;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            int choice = -1;
            while (isRunning)
            {

                if (choice == -1)
                {
                    choice = ConsoleUtility.MainMenu();
                }
                else if (choice == 1)
                {
                    int circle_choice = CircleUI.Menu();
                    do
                    {
                        switch (circle_choice)
                        {
                            case 1:
                                Circle circle = CircleUI.AddCircle();
                                CircleCRUD.AddCircle(circle);
                                break;
                            case 2:
                                CircleUI.ShowAllCircles(CircleCRUD.GetAllCircles());
                                break;
                            case 3:
                                choice = -1;
                                break;
                            default:
                                Console.WriteLine("Invalid circle_choice. Please try again.");
                                break;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        circle_choice = CircleUI.Menu();

                    } while (circle_choice != 3);
                }
                else if (choice == 2)
                {
                    int cylinder_choice = CylinderUI.Menu();
                    do
                    {
                        switch (cylinder_choice)
                        {
                            case 1:
                                Cylinder Cylinder = CylinderUI.AddCylinder();
                                CylinderCRUD.AddCylinder(Cylinder);
                                break;
                            case 2:
                                CylinderUI.ShowAllCylinders(CylinderCRUD.GetAllCylinders());
                                break;
                            case 3:
                                choice = -1;
                                break;
                            default:
                                Console.WriteLine("Invalid cylinder_choice. Please try again.");
                                break;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        cylinder_choice = CylinderUI.Menu();
                    } while (cylinder_choice != 3);
                }
                else if (choice == 3)
                {
                    isRunning = false;
                }
                else
                {
                    choice = -1;
                    Console.WriteLine("Invalid choice. Please try again.");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}