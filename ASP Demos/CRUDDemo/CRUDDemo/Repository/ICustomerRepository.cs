using CRUDDemo.Models;

namespace CRUDDemo.Repository
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer cust);
        void UpdateCustomer(int id, Customer cust);
        void DeleteCustomer(int id);
        Customer GetCustomer(int id);
        List<Customer> GetCustomers();
    }
}
