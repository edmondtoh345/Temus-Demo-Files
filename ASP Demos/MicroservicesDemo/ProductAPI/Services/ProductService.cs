using ProductAPI.Exceptions;
using ProductAPI.Models;
using ProductAPI.Repository;

namespace ProductAPI.Services
{
    public class ProductService : IProductServices
    {
        private readonly IProductRepository repo;

        public ProductService(IProductRepository repo)
        {
            this.repo = repo;
        }

        public int AddProduct(Product product)
        {
            var p = repo.GetProduct(product.Id);
            if(p== null)
            {
                return repo.AddProduct(product);
            }
            throw new ProductAlreadyExistsException($"Product with {product.Id} already exists");
        }

        public int DeleteProduct(int id)
        {
            var p = repo.GetProduct(id);
            if (p == null)
            {
                throw new ProductNotFoundException($"Product with {id} does not exists");
            }
            return repo.DeleteProduct(id);

        }

        public Product GetProduct(int id)
        {
            var p = repo.GetProduct(id);
            if (p == null)
            {
                throw new ProductNotFoundException($"Product with {id} does not exists");
            }
            return repo.GetProduct(id);
        }

        public List<Product> GetProducts()
        {
            return repo.GetProducts();
        }

        public int UpdateProduct(int id, Product product)
        {
            var p = repo.GetProduct(id);
            if (p == null)
            {
                throw new ProductNotFoundException($"Product with {id} does not exists");
            }
            return repo.UpdateProduct(id, product);
        }
    }
}
