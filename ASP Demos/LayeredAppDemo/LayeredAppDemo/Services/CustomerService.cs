using LayeredAppDemo.Exceptions;
using LayeredAppDemo.Models;
using LayeredAppDemo.Repository;

namespace LayeredAppDemo.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository repo;

        public CustomerService(ICustomerRepository repo)
        {
            this.repo = repo;
        }

        public int AddCustomer(Customer customer)
        {
            if (repo.GetCustomer(customer.CustomerId) != null)
            {
                throw new CustomerAlreadyExistsException($"Customer with id: {customer.CustomerId} already exists");
            }
            return repo.AddCustomer(customer);
        }

        public int DeleteCustomer(int id)
        {
            if (repo.GetCustomer(id) == null)
            {
                throw new CustomerNotFoundException($"Customer with id: {id} does not exists");
            }
            return repo.DeleteCustomer(id);
        }

        public Customer GetCustomer(int id)
        {
            var res = repo.GetCustomer(id);
            if (res == null)
            {
                throw new CustomerNotFoundException($"Customer with id: {id} does not exists");
            }
            return res;
        }

        public List<Customer> GetCustomers()
        {
            return repo.GetCustomers();
        }

        public int UpdateCustomer(int id, Customer customer)
        {
            if (repo.GetCustomer(id) == null)
            {
                throw new CustomerNotFoundException($"Customer with id: {id} does not exists");
            }
            return repo.UpdateCustomer(id, customer);
        }
    }
}
