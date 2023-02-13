using MongoDB.Driver;

namespace AuthAPI.Models
{
    public class DataContext
    {
        MongoClient client;
        IMongoDatabase db;
        public DataContext()
        {
            client= new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase("AuthDB");
        }

        public IMongoCollection<User> Users => db.GetCollection<User>("Users");
    }
}
