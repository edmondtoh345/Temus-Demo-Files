using AuthDemo.Models;
using AuthDemo.Repository;
using AuthDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace AuthDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository repo;
        private readonly ITokenGeneratorService service;
        public UserController(IUserRepository repo, ITokenGeneratorService service)
        {
            this.repo = repo;
            this.service = service;
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            int res = repo.RegisterUser(user);
            if (res == 1)
            {
                return Ok("User registered successfully");
            }
            return StatusCode(500, "Something went wrong");
        }

        [HttpPost("login")]
        public IActionResult Login(Cred user)
        {
            if (repo.Login(user.Username, user.Password))
            {
                return Ok(service.GenerateToken(user));
            }
            else
            {
                return StatusCode(401, "Invalid username or password");
            }
        }

        [HttpPost("isauthenticated")]
        public IActionResult IsAuthenticated()
        {
            string token = Request.Headers.Authorization;
            TokenValidationParameters validationParameters = new TokenValidationParameters()
            {
                ValidAudience = "customerapi",
                ValidIssuer = "authapi",
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this_is_my_secret_key_for_user"))
            };
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            SecurityToken securitytoken;
            if (handler.CanReadToken(token)) 
            {
                var user = handler.ValidateToken(token, validationParameters, out securitytoken);
                return Ok("valid");
            }
            return StatusCode(401, "Error");
        }
    }
}
