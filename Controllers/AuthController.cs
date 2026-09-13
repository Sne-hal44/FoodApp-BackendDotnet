using FoodApp.Dtos.Users;
using FoodApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.Controllers
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

        // POST: api/auth/login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _authService.LoginAsync(loginDto);

            // If login fails, we return a 401 Unauthorized status with the error message
            if (!response.IsValid)
            {
                return Unauthorized(response);
            }

            // If login succeeds, return 200 OK along with the success payload
            return Ok(response);
        }
    }
}
