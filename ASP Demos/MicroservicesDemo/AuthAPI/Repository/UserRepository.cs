using AuthAPI.Models;
using MongoDB.Driver;

namespace AuthAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext db;

        public UserRepository(DataContext db)
        {
            this.db = db;
        }

        public bool Login(string email, string password)
        {
            return db.Users.Find(x => x.Email== email && x.Password==password).Any();
        }

        public User RegisterUser(User user)
        {
            db.Users.InsertOne(user);
            return user;
        }

        public bool GetUserByEmail(string email)
        {
            return db.Users.Find(x => x.Email== email).Any();
        }
    }
}
