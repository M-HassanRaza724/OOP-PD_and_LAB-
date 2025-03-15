namespace ProductManagement
{
    public class ProductUI
    {
        public static Product TakeInputOfProduct()
        {
            string name = "", category = "";
            float price = 0.0F;
            int quantity = 0, threshold = 0;
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter category: ");
            category = Console.ReadLine();
            Console.Write("Enter Price: ");
            price = float.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter minimum threshold value: ");
            threshold = int.Parse(Console.ReadLine());
            return new Product(name, category, price, quantity, threshold);
        }

        public static string InputProductName()
        {
            Console.WriteLine("Enter product name: ");
            return Console.ReadLine();
        }

        public static int InputProductQuantity()
        {
            Console.WriteLine("Enter product Quantity: ");
            return int.Parse(Console.ReadLine());
        }

        public static void PrintProduct(Product p)
        {
            Console.WriteLine($"{p.Name}\t\t{p.Category}\t\t{p.Price}\t\t{p.StockQuantity}\t\t{p.MinQuantity}");
        }
        public static void PrintProduct(List<Product> products)
        {
            foreach (Product p in products)
                Console.WriteLine($"{p.Name}\t\t{p.Category}\t\t{p.Price}\t\t{p.StockQuantity}\t\t{p.MinQuantity}");
        }
    }
}
