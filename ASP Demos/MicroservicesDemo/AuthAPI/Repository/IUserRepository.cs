using AuthAPI.Models;

namespace AuthAPI.Repository
{
    public interface IUserRepository
    {
        User RegisterUser(User user);
        bool Login(string email, string password);
        bool GetUserByEmail(string email);
    }
}
