using MongoDB.Driver;
namespace MongoDBAPI.Models
{
    public class DataContext
    {
        MongoClient client;
        IMongoDatabase db;

        public DataContext()
        {
            client = new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase("CyberShop");
        }

        public IMongoCollection<Product> Products => db.GetCollection<Product>("Product");
    }
}

