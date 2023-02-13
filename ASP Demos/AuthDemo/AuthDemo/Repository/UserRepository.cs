using AuthDemo.Models;

namespace AuthDemo.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext db;

        public UserRepository(DataContext db)
        {
            this.db = db;
        }

        public bool Login(string username, string password)
        {
            return db.Users.Any(x => x.Username == username && x.Password == password);
        }

        public int RegisterUser(User user)
        {
            db.Users.Add(user);
            return db.SaveChanges();
        }
    }
}
