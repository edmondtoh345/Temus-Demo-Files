namespace EntityFrameworkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContext d = new DataContext();
            // For adding/inserting new record
            //d.Products.Add(new Product() { ProductName = "Tablet", Brand = "Lenovo", Quantity = 3, Price = 499 });
            //d.SaveChanges();

            //For data retrieval
            //var products = d.Products.ToList();
            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item.Id} {item.ProductName} {item.Brand} {item.Quantity} {item.Price}");
            //}

            //For Delete
            //var p = d.Products.ToList().Find(x => x.Id == 2);
            //d.Products.Remove(p);
            //d.SaveChanges();

            //For Update
            var p = d.Products.ToList().Find(x => x.Id == 1);
            p.ProductName = "Desktop";
            p.Brand = "HP";
            p.Quantity = 2;
            p.Price = 35000;
            d.Products.Update(p);
            d.SaveChanges();
        }
    }
}