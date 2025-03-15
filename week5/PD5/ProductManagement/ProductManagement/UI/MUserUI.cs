namespace ProductManagement
{
    public class MUserUI
    {
        static public int EntryMenu()
        {
            Console.WriteLine("\t\t\tMENU");
            Console.WriteLine("\t1. Log In.");
            Console.WriteLine("\t2. Sign Up.");
            Console.WriteLine("\t3. Exit.");
            Console.Write("\tEnter your choice: ");
            return int.Parse(Console.ReadLine());
        }

        static public MUser signInInput()
        {
            string email, password;
            Console.WriteLine("Enter username: ");
            email = Console.ReadLine();
            Console.WriteLine("Enter  password: ");
            password = Console.ReadLine();

            return new MUser(email, password);
        }
        static public MUser signUpInput()
        {
            string username, email, password;

            username = Console.ReadLine();
            Console.WriteLine("Enter username: ");
            Console.WriteLine("Enter email: ");
            email = Console.ReadLine();
            Console.WriteLine("Enter  password: ");
            password = Console.ReadLine();

            return new MUser(username, email, password);
        }
        public static string InputPassword()
        {
            Console.Write("Enter Password: ");
            return Console.ReadLine();
        }
        public static void ViewProfile(MUser user)
        {
            Console.WriteLine($"Username =  {user.getUsername()}");
            Console.WriteLine($"Email =  {user.getEmail()}");
            Console.WriteLine($"UserRole =  {user.getUserRole()}");
            
        }
    }
}
