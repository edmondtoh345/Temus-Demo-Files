using AuthDemo.Models;

namespace AuthDemo.Services
{
    public interface ITokenGeneratorService
    {
        string GenerateToken(Cred user);
    }
}
