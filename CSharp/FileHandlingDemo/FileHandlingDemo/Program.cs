public class Customer
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
}
public class Program
{
    public static void Main(string[] args)
    {
        FileStream fs = new FileStream(@"E:\Temus-Training-Demo-Files\Data.csv", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        List<Customer> list = new List<Customer>();
        string str;
        while ((str = sr.ReadLine()) != null){
            string [] row = str.Split(",");
            list.Add(new Customer() { Id=row[0], Name=row[1], CompanyName=row[2], Address=row[3], City=row[4] });
        }
        Console.WriteLine("Enter Customer ID");
        string id = Console.ReadLine();
        foreach (var item in list)
        {
            if (item.Id == id)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.CompanyName} {item.Address} {item.City}");
                break;
            }
        }
    }
}