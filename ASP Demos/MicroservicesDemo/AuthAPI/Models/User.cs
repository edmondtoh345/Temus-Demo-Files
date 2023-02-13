using MongoDB.Bson.Serialization.Attributes;

namespace AuthAPI.Models
{
    public class User
    {
        [BsonId]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}
