using Task1.BL;
using Task1.UI;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder();
            Cylinder c2 = new Cylinder(2,3);
            Cylinder c3 = new Cylinder(5);

            // setting heights
            c1.SetHeight(5);
            c3.SetHeight(5);

            // getting volumes
            ConsoleUtility.PirntMessage($"{c1.ToString()}");
            ConsoleUtility.PirntMessage($"{c2.ToString()}");
            ConsoleUtility.PirntMessage($"{c3.ToString()}");
        }
    }
}
