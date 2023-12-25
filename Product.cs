namespace ConsoleApp13
{
    internal class Product
    {
        public static string path = "products.csv"; //bin\Debug\net6.0
        public static List<Product> products = new(FileWork.Deserialization<Product>(path));

        public Product(int id, string name, int price, int available)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.available = available;
        }

        public int id { get; set;}
        public string name { get; set;}
        public int price { get; set;}
        public int available { get; set;}
    }

    internal class SelectedProduct : Product
    {
        public SelectedProduct(int id, string name, int price, int available, int selected) : base(id, name, price, available)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.available = available;
            this.selected = selected;
        }

        public int selected { get; set;}
    }
}
