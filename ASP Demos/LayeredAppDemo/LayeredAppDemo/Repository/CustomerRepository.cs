using LayeredAppDemo.Models;

namespace LayeredAppDemo.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext db;

        public CustomerRepository(DataContext db)
        {
            this.db = db;
        }

        public int AddCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            return db.SaveChanges();
        }

        public int DeleteCustomer(int id)
        {
            var c = db.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
            db.Customers.Remove(c);
            return db.SaveChanges();
        }

        public Customer GetCustomer(int id)
        {
            return db.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
        }

        public List<Customer> GetCustomers()
        {
            return db.Customers.ToList();
        }

        public int UpdateCustomer(int id, Customer customer)
        {
            var c = db.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
            c.FirstName = customer.FirstName;
            c.LastName = customer.LastName;
            c.Email = customer.Email;
            c.Age = customer.Age;
            db.Entry<Customer>(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
