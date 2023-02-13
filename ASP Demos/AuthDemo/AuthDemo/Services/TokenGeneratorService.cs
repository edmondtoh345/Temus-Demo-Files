using AuthDemo.Models;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthDemo.Services
{
    public class TokenGeneratorService : ITokenGeneratorService
    {
        public string GenerateToken(Cred user)
        {
            var claims = new[]
            {
                new Claim("username", user.Username)
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
    }
}
