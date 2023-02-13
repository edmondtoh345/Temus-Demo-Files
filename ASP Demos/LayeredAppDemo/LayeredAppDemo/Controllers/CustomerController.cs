using LayeredAppDemo.Exceptions;
using LayeredAppDemo.Filters;
using LayeredAppDemo.Models;
using LayeredAppDemo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LayeredAppDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[MyException]
    // [Authorize]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService service;

        public CustomerController(ICustomerService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetCustomers());
        }

        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            return Ok(service.AddCustomer(customer));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetCustomer(id));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(service.DeleteCustomer(id));
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Customer customer)
        {
            return Ok(service.UpdateCustomer(id, customer));
        }
    }
}
