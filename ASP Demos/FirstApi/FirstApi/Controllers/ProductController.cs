using FirstApi.Models;
using FirstApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
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
            //return StatusCode(201, repo.GetProducts());
            return Ok(repo.GetProducts());
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            repo.AddProduct(product);
            return StatusCode(201, "Product Addedd Successfully");
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var product = repo.GetProduct(id);
            if(product == null)
            {
                return NotFound($"Product with id: {id} does not exists");
            }
            return Ok(product);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            int res = repo.DeleteProduct(id);
            if(res == 0)
            {
                return NotFound($"Product with id: {id} does not exists");
            }
            return Ok("Product Deleted Successfully");
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Product product)
        {
            int res = repo.UpdateProduct(id, product);
            if (res == 0)
            {
                return NotFound($"Product with id: {id} does not exists");
            }
            return Ok("Product Updated Successfully");
        }
    }
}
