using FoodApp.Dtos.Users;
using FoodApp.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace FoodApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ActionResult<IEnumerable<UserResponseDto>>> GetAllUser()
        {
            return Ok(await _userService.GetAllUserAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(CreateUserDto userDto)
        {
            var user = await _userService.AddUserAsync(userDto);

            return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(CreateUserDto userDto)
        {
            var user = await _userService.UpdateUserAsync(userDto);

            return Ok(user);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);

            if (user == null)
                return NotFound("User not found");

            return Ok(user);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var deleted = await _userService.DeleteUserAsync(id);

            if (!deleted)
                return NotFound("User not found");

            return NoContent();
        }
    }
}
