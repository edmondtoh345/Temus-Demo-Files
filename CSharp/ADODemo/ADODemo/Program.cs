using System.Data.SqlClient;

namespace ADODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Server=.\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=true");
            con.Open();
            Console.WriteLine("Enter Customer ID");
            int id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Customer Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Phone");
            string phone = Console.ReadLine();

            SqlCommand cmd = new SqlCommand($"insert into Customers values({id}, '{name}', '{email}', '{phone}')", con);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Record Inserted Successfully");
            
            con.Close();
        }
    }
}