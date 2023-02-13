using CRUDDemo.Models;

namespace CRUDDemo.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private static List<Customer> customers = new List<Customer>();
        public void AddCustomer(Customer cust)
        {
            customers.Add(cust);
        }

        public void DeleteCustomer(int id)
        {
            customers.Remove(customers.Find(x => x.Id == id));
        }

        public Customer GetCustomer(int id)
        {
            return customers.Find(x => x.Id == id);
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }

        public void UpdateCustomer(int id, Customer cust)
        {
            var c = customers.Find(x => x.Id == id);
            c.Name = cust.Name;
            c.Email = cust.Email;
            c.City = cust.City;
            c.Age = cust.Age;
        }
    }
}
