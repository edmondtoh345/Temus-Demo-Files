using MongoDBAPI.Models;

namespace MongoDBAPI.Repository
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        List<Product> GetProducts();
        Product GetProduct(int id);
        void DeleteProduct(int id);
        void UpdateProduct(int id, Product product);
    }
}
