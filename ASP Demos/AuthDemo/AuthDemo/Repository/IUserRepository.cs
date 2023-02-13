using AuthDemo.Models;

namespace AuthDemo.Repository
{
    public interface IUserRepository
    {
        int RegisterUser(User user);
        bool Login(string username, string password);
    }
}
