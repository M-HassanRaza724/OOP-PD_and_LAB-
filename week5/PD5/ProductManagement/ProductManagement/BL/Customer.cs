using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    class Customer
    {
        public string Name;
        public string Email;
        List<Product> Products;

        public Customer() { }
        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
            Products = new List<Product>();
        }
        public Customer(string name, string email, List<Product> products)
        {
            Name = name;
            Email = email;
            Products = products;
        }
        public bool BuyProduct(Product p,int stock)
        {
            if(p.BoughtQuantity < stock)
            {
                Products.Add(p);
                return true;
            }
            return false;
        }

        public float Invoice()
        {
            float total = 0F;
            foreach (Product p in Products)
                total += (p.Price - p.TaxCalculator());
            return total;
        }
    }
}
