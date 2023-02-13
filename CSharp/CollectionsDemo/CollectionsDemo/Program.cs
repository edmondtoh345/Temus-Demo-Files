public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
}

class SortByQuantity : IComparer<Product>
{
    public int Compare(Product? x, Product? y)
    {
        if (x.Quantity > y.Quantity)
        {
            return 1;
        }else if(x.Quantity < y.Quantity)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}

class SortByPrice : IComparer<Product>
{
    public int Compare(Product? x, Product? y)
    {
        if (x.Price > y.Price)
        {
            return 1;
        }
        else if (x.Price < y.Price)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        //Product p1 = new Product() { Id = 1, Name = "Laptop", Brand = "Dell", Quantity = 5, Price = 300 };
        //Product p2 = new Product() { Id = 2, Name = "Tablet", Brand = "Lenovo", Quantity = 7, Price = 100 };
        //products.Add(p1);
        //products.Add(p2);

        products.Add(new Product { Id = 1, Name = "Laptop", Brand = "Dell", Quantity = 5, Price = 300 });
        products.Add(new Product { Id = 2, Name = "Tablet", Brand = "Lenovo", Quantity = 7, Price = 100 });
        products.Add(new Product { Id = 3, Name = "Mobile", Brand = "Apple", Quantity = 9, Price = 700 });
        products.Add(new Product { Id = 4, Name = "Desktop", Brand = "HP", Quantity = 8, Price = 650 });
        products.Add(new Product { Id = 5, Name = "Earbuds", Brand = "Apple", Quantity = 3, Price = 250 });
        products.Sort(new SortByPrice());
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"{products[i].Id} {products[i].Name} {products[i].Brand} {products[i].Quantity} {products[i].Price}");
        }

    }
}