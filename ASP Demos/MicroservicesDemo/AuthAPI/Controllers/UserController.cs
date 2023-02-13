using AuthAPI.Exceptions;
using AuthAPI.Models;
using AuthAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService service;

        public UserController(IUserService service)
        {
            this.service = service;
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            try
            {
                return Ok(service.RegisterUser(user));
            }
            catch (UserAlreadyExistsException e)
            {
                return StatusCode(409, e.Message);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost("login")]
        public IActionResult Login(Cred user)
        {
            try
            {
                if (service.Login(user.Email, user.Password))
                    return Ok(service.GenerateToken(user.Email));
                return StatusCode(401, "Invalid Credentials");
            }
            catch (InvalidCredentialsException e)
            {
                return StatusCode(401, e.Message);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
