using MongoDBAPI.Models;
using MongoDB.Driver;
namespace MongoDBAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext db;
        public ProductRepository(DataContext db)
        {
            this.db = db;
        }

        public void AddProduct(Product product)
        {
            db.Products.InsertOne(product);
        }

        public void DeleteProduct(int id)
        {
            db.Products.DeleteOne(x => x.Id == id);
        }

        public Product GetProduct(int id)
        {
            return db.Products.Find(x => x.Id == id).FirstOrDefault();
        }

        public List<Product> GetProducts()
        {
            return db.Products.Find(x => true).ToList();
        }

        public void UpdateProduct(int id, Product product)
        {
            var filter = Builders<Product>.Filter.Where(x => x.Id == id);
            var update = Builders<Product>.Update.Set(x => x.Name, product.Name)
                .Set(x => x.Brand, product.Brand)
                .Set(x => x.Quantity, product.Quantity)
                .Set(x => x.Price, product.Price);
            db.Products.UpdateOne(filter, update);
        }
    }
}
