


using Org.BouncyCastle.Asn1.X509;

namespace ProductManagement
{
    class Program
    {
        static void Main(string[] arg)
        {
            MUser user;
            bool exit = false;
            int Role = 0;
            do
            {

                int choice = MUserUI.EntryMenu();
                if(Role == 0)
                {
                    if (choice == 1)
                    {
                        MUser u = MUserUI.signInInput();
                        if (MUser.AuthenticateUser(u))
                        {
                            user = u;
                            Role = user.UserRole;
                        }
                    }
                    else if (choice == 2)
                    {
                        MUser u = MUserUI.signUpInput();

                        if (MUser.AuthenticateUser(u))
                            Console.WriteLine("User is already present...");
                        else
                            MUserCRUD.AddUser(u);
                    }
                    else if (choice == 3)
                        exit = true;
                }
                else if (Role == 1)
                {
                    int a_Choice = AdminUI.AdminMenu();
                    do
                    {
                        switch (a_Choice)
                        {
                            case 1:
                                ProductCRUD.AddProduct(ProductUI.TakeInputOfProduct());
                                break;
                            case 2:
                                List<Product> products = ProductCRUD.getAllProducts();
                                break;
                            case 3:
                                ProductUI.PrintProduct(ProductCRUD.HighestPricedProduct());
                                break;
                            case 4:
                                Console.WriteLine("Name\t\tCategory\tPrice\t\tSalesTax");
                                foreach (Product P in ProductCRUD.getAllProducts())
                                    ProductUI.PrintProduct(P);
                                break;
                            case 5:
                                Console.WriteLine("Name\t\tCategory\tPrice\t\tStockQuantity\t\tMinQuantity\t\t");
                                ProductUI.PrintProduct(ProductCRUD.getProductsToBeOrdered());
                                    break;
                            case 6:
                                if (user.AuthenticateUser(MUserUI.InputPassword()))
                                    MUserUI.ViewProfile(user);
                                break;
                        }
                        a_Choice = AdminUI.AdminMenu();
                    } while (a_Choice != 7);
                    Role = 0;
                }
                else if (Role == 2)
                {
                    int c_Choice = CustomerUI.CustomerMenu();
                    do
                    {
                        switch (c_Choice)
                        {
                            case 1:
                                List<Product> products = ProductCRUD.getAllProducts();
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                if (user.AuthenticateUser(MUserUI.InputPassword()))
                                {
                                    MUserUI.ViewProfile(user);
                                }
                                break;
                        }
                    } while (c_Choice != 5);

                }



                while (Choice != 6)
                {
                    switch (Choice)
                    {
                        case 1:
                            Product P = ProductUI.TakeInputOfProduct();

                            ProductCRUD.AddProducts(P);
                            break;
                        case 2:
                            Console.WriteLine("Name\t\tCategory\tPrice\t\tStockQuantity\t\tMinQuantity\t\t");
                            foreach (Product P in ProductCRUD.Products)
                                ProductUI.PrintProduct(P);
                            break;
                        case 3:
                            Console.WriteLine("Name\t\tCategory\tPrice\t\tStockQuantity\t\tMinQuantity\t\t");
                            ProductUI.PrintProduct((ProductCRUD.HighestPricedProduct(ProductCRUD.Products)));
                            break;
                        case 4:
                            Console.WriteLine("Name\t\tCategory\tPrice\t\tSalesTax");
                            foreach (Product P in ProductCRUD.Products)
                                Console.WriteLine($"{P.Name}\t\t{P.Category}\t\t{P.Price}\t\t{P.TaxCalculator()}");
                            break;
                        case 5:
                            Console.WriteLine("Name\t\tCategory\tPrice\t\tStockQuantity\t\tMinQuantity\t\t");
                            foreach (Product P in ProductCRUD.Products)
                                if (P.MinQuantity > P.StockQuantity)
                                    ProductUI.PrintProduct(P);
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Choice = CustomerUI.CustomerMenu();
                }
            } while (!exit);
 
   
        }
    }
}