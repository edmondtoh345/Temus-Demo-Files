using CRUDApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace CRUDApp.Controllers
{
    public class HomeController : Controller
    {
        public static List<Product> productlist = new List<Product>()
        {
            new Product{ Id = 1, Name = "Laptop", Brand = "Dell", Quantity = 5, Price = 899 },
            new Product{ Id = 2, Name = "Camera", Brand = "Nikon", Quantity = 2, Price = 1099 },
            new Product{ Id = 3, Name = "Tablet", Brand = "Apple", Quantity = 9, Price = 799 },
        };

        public IActionResult Index()
        {
            return View("HomePage", productlist);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                productlist.Add(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            var p = productlist.Find(x => x.Id == id);
            return View(p);
        }

        public IActionResult Delete(int id)
        {
            var p = productlist.Find(x => x.Id == id);
            return View(p);
        }

        [HttpPost]
        public IActionResult Delete(int id, Product p)
        {
            productlist.Remove(productlist.Find(x => x.Id == id));
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var p = productlist.Find(x => x.Id == id);
            return View(p);
        }

        [HttpPost]
        public IActionResult Edit(int id, Product product)
        {
            var p = productlist.Find(x => x.Id == id);
            p.Name = product.Name;
            p.Brand = product.Brand;
            p.Price = product.Price;
            p.Quantity = product.Quantity;
            return RedirectToAction("Index");
        }


    }
}
