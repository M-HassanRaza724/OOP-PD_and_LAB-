

namespace ProductManagement
{
    public class ProductCRUD
    {
        static public Product HighestPricedProduct()
        {
            List<Product> products = getAllProducts();
            Product MaxPriceProduct = new Product();
            foreach (Product product in products)
            {
                if (product.Price > MaxPriceProduct.Price)
                {
                    MaxPriceProduct = product;
                }
            }
            return MaxPriceProduct;
        }
        static public void AddProduct(Product product)
        {
            string query = $"INSERT INTO Products VALUES ('{product.getName()}', '{product.getCategory()}', '{product.getPrice()}', '{product.getStockQuantity()}', '{product.getMinQuantity()}')";
            DatabaseHelper.Instance.Update(query);
        }

        static public void EditProduct(Product product)
        {
            string query = $"UPDATE Products SET StockQuantity = '{product.getStockQuantity()}'  WHERE ProductName = '{product.getName()}'";
            DatabaseHelper.Instance.Update(query);
        }

        static public Product IsProductPresent(string pName)
        {
            string query = $"SELECT * FROM Products WHERE ProductName = '{pName}'";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                return new Product($"{reader["ProductName"]}", $"{reader["Category"]}", float.Parse($"{reader["Price"]}"), int.Parse($"{reader["StockQuantity"]}"), int.Parse($"{reader["MinQuantity"]}"));
            }
            return new Product();
        }
        static public List<Product> getAllProducts()
        {
            List<Product> Products = new List<Product>();
            string query = "SELECT * FROM Products";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                Products.Add(new Product($"{reader["ProductName"]}", $"{reader["Category"]}", float.Parse($"{reader["Price"]}"), int.Parse($"{reader["StockQuantity"]}"), int.Parse($"{reader["MinQuantity"]}")));
            }
            return Products;
        }
        static public List<Product> getProductsToBeOrdered()
        {
            List<Product> Products = new List<Product>();
            string query = "SELECT * FROM Products where StockQuantity < MinQuantity";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                Products.Add(new Product($"{reader["ProductName"]}", $"{reader["Category"]}", float.Parse($"{reader["Price"]}"), int.Parse($"{reader["StockQuantity"]}"), int.Parse($"{reader["MinQuantity"]}")));
            }
            return Products;
        }
    }
}

