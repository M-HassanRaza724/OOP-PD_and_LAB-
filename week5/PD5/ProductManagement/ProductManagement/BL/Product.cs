namespace ProductManagement
{
    public class Product
    {
        public string Name;
        public string Category;
        public float Price;
        public int StockQuantity;
        public int MinQuantity;
        public int BoughtQuantity;


        public string getName()
        {
            return Name;
        }
        public string getCategory()
        {
            return Category;
        }
        public float getPrice()
        {
            return Price;
        }
        public int getStockQuantity()
        {
            return StockQuantity;
        }
        public int getMinQuantity()
        {
            return MinQuantity;
        }

        public Product()
        {
            StockQuantity = 0;
            MinQuantity = 10;
            Price = 0F;
        }
        public Product(string name, string category, float price, int stockQuantity, int minQuantity = 10)
        {
            Name = name;
            Category = category.ToLower();  
            Price = price;
            StockQuantity = stockQuantity;
            MinQuantity = minQuantity;
        }
        public Product(string name, string category, float price, int boughtQuantity)
        {
            Name = name;
            Category = category.ToLower();
            Price = price;
            BoughtQuantity = boughtQuantity;
        }
        public Product(Product P)
        {
            Name = P.Name;
            Category = P.Category;
            Price = P.Price;
            StockQuantity = P.StockQuantity;
            MinQuantity = P.MinQuantity;
        }
        public float TaxCalculator()
        {
            if (Category == "grocery")
                return Price * 0.1F;
            else if (Category == "fruit")
                return Price * 0.05F;
            else return Price * 0.15F;
        }

    }
}
