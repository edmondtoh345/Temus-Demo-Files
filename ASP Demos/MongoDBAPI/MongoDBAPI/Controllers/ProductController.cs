using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDBAPI.Models;
using MongoDBAPI.Repository;

namespace MongoDBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository repo;

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(repo.GetProducts());
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            repo.AddProduct(product);
            return StatusCode(201, "Product Added Successfully");
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(repo.GetProduct(id));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            repo.DeleteProduct(id);
            return Ok("Product Deleted Successfully");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Product product)
        {
            repo.UpdateProduct(id, product);
            return Ok("Product updated successfully");
        }


    }
}
