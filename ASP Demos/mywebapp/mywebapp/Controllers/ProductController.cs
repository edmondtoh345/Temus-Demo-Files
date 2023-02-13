using Microsoft.AspNetCore.Mvc;
using mywebapp.Models;

namespace mywebapp.Controllers
{
    public class ProductController : Controller
    {
        private readonly List<Product> productlist;

        public ProductController()
        {
            productlist = new List<Product>()
            {
                new Product() {Id=1, Name="Laptop", Brand="Dell", Quantity=7, Price=799},
                new Product() {Id=2, Name="Tablet", Brand="Lenovo", Quantity=5, Price=299},
                new Product() {Id=3, Name="Camera", Brand="Canon", Quantity=2, Price=1099},
            };
        }

        public string Hello()
        {
            return "Hello World";
        }

        public IActionResult Index()
        {
            ViewBag.Username = "Dhiraj";
            ViewBag.Email = "Dhiraj.Kumar@niit.com";
            return View();
        }

        public IActionResult List()
        {
            ViewBag.Products = productlist;
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
