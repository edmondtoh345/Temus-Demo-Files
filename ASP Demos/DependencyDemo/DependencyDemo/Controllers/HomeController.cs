using DependencyDemo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DependencyDemo.Controllers
{
    public class HomeController : Controller
    {
        private IGenerator gen;
        private IGenerator gen2;

        public HomeController(IGenerator gen, IGenerator gen2) 
        {
            this.gen = gen;
            this.gen2 = gen2;
        }

        public IActionResult Index()
        {
            ViewBag.Instance1 = gen.GetID();
            ViewBag.Instance2 = gen2.GetID();
            return View();
        }
    }
}
