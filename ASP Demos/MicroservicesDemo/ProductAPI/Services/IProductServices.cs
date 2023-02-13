using ProductAPI.Models;

namespace ProductAPI.Services
{
    public interface IProductServices
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        int AddProduct(Product product);
        int UpdateProduct(int id, Product product);
        int DeleteProduct(int id);
    }
}
