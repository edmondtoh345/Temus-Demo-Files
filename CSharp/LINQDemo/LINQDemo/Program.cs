namespace LINQDemo
{
    public class EmployeeData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeData> employees = new List<EmployeeData>();
            employees.Add(new EmployeeData { ID = 1, Name = "Edmond", Email = "pear@gmail.com", Age = 25 });
            employees.Add(new EmployeeData { ID = 2, Name = "Jun Hao", Email = "orange@gmail.com", Age = 30 });
            employees.Add(new EmployeeData { ID = 3, Name = "Kai Heng", Email = "banana@gmail.com", Age = 35 });
            employees.Add(new EmployeeData { ID = 4, Name = "Sidney", Email = "apple@gmail.com", Age = 33 });
            employees.Add(new EmployeeData { ID = 5, Name = "Eric", Email = "chocolate@gmail.com", Age = 28 });

            var query = employees.Where(x => x.Age > 30).OrderBy(x => x.ID).ToList();
        }
    }
}