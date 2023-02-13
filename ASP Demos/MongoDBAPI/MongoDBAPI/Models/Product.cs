using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBAPI.Models
{
    public class Product
    {
        [BsonId]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
