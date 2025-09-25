using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.API.DTOs;
using EmployeeManagement.API.Services;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        // ✅ Register a new user (open, no token required)
        [HttpPost("register")]
        [AllowAnonymous]
        //public async Task<IActionResult> Register([FromBody] RegisterDto dto)
        //{
            //var result = await _authService.RegisterAsync(dto);
           // if (!result.Success)
             //   return BadRequest(result.Message);

           // return Ok(result.Message);
       // }

        // ✅ Login user and return JWT token
        [HttpPost("login")]
        //[AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            var token = await _authService.LoginAsync(dto);
            if (string.IsNullOrEmpty(token))
                return Unauthorized("Invalid username or password");

            return Ok(new { Token = token });
        }
    }
}
