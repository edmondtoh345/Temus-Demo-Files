using CRUDDemo.Models;
using CRUDDemo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CRUDDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerRepository repo;
        public HomeController(ICustomerRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var result = repo.GetCustomers();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer cust)
        {
            repo.AddCustomer(cust);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(repo.GetCustomer(id));
        }

        public IActionResult Edit(int id)
        {
            return View(repo.GetCustomer(id));
        }

        [HttpPost]
        public IActionResult Edit(int id, Customer cust)
        {
            repo.UpdateCustomer(id, cust);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            return View(repo.GetCustomer(id));
        }

        [HttpPost]
        public IActionResult Delete(int id, Customer cust)
        {
            repo.DeleteCustomer(id);
            return RedirectToAction("Index");
        }
    }
}
