using AuthAPI.Models;

namespace AuthAPI.Services
{
    public interface IUserService
    {
        User RegisterUser(User user);
        bool Login(string email, string password);
        string GenerateToken(string email);
    }
}
