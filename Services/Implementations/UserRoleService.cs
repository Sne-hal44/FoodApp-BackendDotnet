using FoodApp.Dtos.Users;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;
using FoodApp.Services.Interfaces;

namespace FoodApp.Services.Implementations
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IUserRoleRepository _userRoleRepository;

        public UserRoleService(IUserRoleRepository userRoleRepository)
        {
            _userRoleRepository = userRoleRepository;
        }

        public async Task<IEnumerable<UserRoleResponseDto>> GetAllUserRolesAsync()
        {
            var roles = await _userRoleRepository.GetUserRoleAsync();

            return roles.Select(s => new UserRoleResponseDto
            {
                Id = s.Id,
                UserRole = s.RoleName,
                IsActive = s.IsActive
            });
        }

      
        public async Task<UserRoleResponseDto?> GetUserRoleByIdAsync(int id)
        {
            var role = await _userRoleRepository.GetUserRoleByIdAsync(id);

            if (role == null)
                return null;

            return new UserRoleResponseDto
            {
                Id = role.Id,
                UserRole = role.RoleName,
                IsActive = role.IsActive
            };
        }

       
        public async Task<UserRoleResponseDto> AddUserRoleAsync(CreateUserRoleDto roleDto)
        {
            var role = new UserRole
            {
                RoleName = roleDto.UserRole
            };

            var createdRole = await _userRoleRepository.AddUserRoleAsync(role);

            return new UserRoleResponseDto
            {
                Id = createdRole.Id,
                UserRole = createdRole.RoleName,
                IsActive = createdRole.IsActive
            };
        }

        
        public async Task<UserRoleResponseDto> UpdateUserRoleAsync(int id, CreateUserRoleDto roleDto)
        {
            var role = new UserRole
            {
                Id = id,
                RoleName = roleDto.UserRole
            };

            var updatedRole = await _userRoleRepository.UpdateUserRoleAsync(role);

            return new UserRoleResponseDto
            {
                Id = updatedRole.Id,
                UserRole = updatedRole.RoleName,
                IsActive = updatedRole.IsActive
            };
        }

                    
        public async Task<bool> DeleteUserRoleAsync(int id)
        {
            return await _userRoleRepository.DeleteUserRoleAsync(id);
        }
    }
}