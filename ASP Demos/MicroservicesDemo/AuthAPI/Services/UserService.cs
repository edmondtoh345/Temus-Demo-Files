using AuthAPI.Exceptions;
using AuthAPI.Models;
using AuthAPI.Repository;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repo;

        public UserService(IUserRepository repo)
        {
            this.repo = repo;
        }

        public string GenerateToken(string email)
        {
            var claims = new[]
            {
                new Claim("email",email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this_is_my_secret_key_for_user"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
               issuer: "authapi",
               audience: "customerapi",
               claims: claims,
               expires: System.DateTime.Now.AddMinutes(20),
               signingCredentials: creds
           );

            var response = new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token)
            };

            return JsonConvert.SerializeObject(response);

        }

        public bool Login(string email, string password)
        {
            if (repo.Login(email, password))
            {
                return true;
            }
            throw new InvalidCredentialsException("Invalid email or password");
        }

        public User RegisterUser(User user)
        {
            if(repo.GetUserByEmail(user.Email))
            {
                throw new UserAlreadyExistsException($"User with {user.Email} already exists");
            }
            return repo.RegisterUser(user);
        }
    }
}
