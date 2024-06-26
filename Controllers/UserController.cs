using Microsoft.AspNetCore.Mvc;
using Projeto.Models;
using Projeto.Services;

namespace Projeto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AuthService _authService;

        public UserController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            if (_authService.Authenticate(user))
            {
                return Ok("Login successful");
            }
            else
            {
                return Unauthorized("Invalid credentials");
            }
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            if (_authService.Register(user))
            {
                return Ok("Registration successful");
            }
            else
            {
                return Conflict("User with this email already exists");
            }
        }
    }
}
