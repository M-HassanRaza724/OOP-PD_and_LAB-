using Task3.BL;
using Task3.UI;
using Task3.DL;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //objects
            Dog dog1 = new Dog("Buddy");
            Dog dog2 = new Dog("Entertainment");
            Cat cat1 = new Cat("Princess");
            Cat cat2 = new Cat("cato");

            MammalCRUD.AddMammal(dog1);
            MammalCRUD.AddMammal(dog2);
            MammalCRUD.AddMammal(cat1);
            MammalCRUD.AddMammal(cat2);


            //methods
            foreach (Mammal mammal in MammalCRUD.mammals)
            {
                mammal.Greet();
            }

            dog1.Greet(dog2);

            // printing
            foreach (Mammal mammal in MammalCRUD.mammals)
            {
                ConsoleUtility.PrintMessage(mammal.ToString());
            }
        }
    }
}