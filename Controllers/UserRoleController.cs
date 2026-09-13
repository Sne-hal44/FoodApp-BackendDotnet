using FoodApp.Dtos.Users;
using FoodApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleService _userRoleService;

        public UserRoleController(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = await _userRoleService.GetAllUserRolesAsync();
            return Ok(roles);
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoleById(int id)
        {
            var role = await _userRoleService.GetUserRoleByIdAsync(id);
            if (role == null)
            {
                return NotFound(new { message = $"User role with ID {id} not found." });
            }
            return Ok(role);
        }

        
        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody] CreateUserRoleDto roleDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdRole = await _userRoleService.AddUserRoleAsync(roleDto);

            return CreatedAtAction(nameof(GetRoleById), new { id = createdRole.Id }, createdRole);
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRole(int id, [FromBody] CreateUserRoleDto roleDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updatedRole = await _userRoleService.UpdateUserRoleAsync(id, roleDto);
            return Ok(updatedRole);
        }

       
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var successfullyDeleted = await _userRoleService.DeleteUserRoleAsync(id);
            if (!successfullyDeleted)
            {
                return NotFound(new { message = $"User role with ID {id} not found." });
            }

            return NoContent();
        }
    }
}
