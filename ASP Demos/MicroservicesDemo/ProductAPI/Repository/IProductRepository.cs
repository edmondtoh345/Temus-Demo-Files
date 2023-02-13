using ProductAPI.Models;

namespace ProductAPI.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        int AddProduct(Product product);
        int UpdateProduct(int id, Product product);
        int DeleteProduct(int id);
    }
}
