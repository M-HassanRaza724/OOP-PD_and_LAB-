using Task4.BL;
using Task4.DL;
using Task4.UI;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes you want to add:");
            int numberOfShapes = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfShapes; i++)
            {
                Console.Write("\nEnter the type of shape (Circle, Rectangle, Square):");
                string shapeType = Console.ReadLine();
                Shape shape = null;
                switch (shapeType.ToLower())
                {
                    case "circle":
                        shape = CircleUI.InputCircle();

                        break;
                    case "rectangle":
                        shape = RectangleUI.InputRectangle();
                        break;
                    case "square":
                        shape = SquareUI.InputSquare();
                        break;
                    default:
                        Console.WriteLine("Invalid shape type.");
                        break;
                }
                if (shape != null)
                {
                    ShapeCRUD.AddShape(shape);
                }
            }
            ConsoleUtility.Print("\nAdded shapes:\n");
            foreach (Shape shape in ShapeCRUD.GetShapes())
            {
                ConsoleUtility.Print(shape.ToStringArea());
            }
        }
    }
}