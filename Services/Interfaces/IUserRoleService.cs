using FoodApp.Dtos.Users;

namespace FoodApp.Services.Interfaces
{
    public interface IUserRoleService
    {
        Task<IEnumerable<UserRoleResponseDto>> GetAllUserRolesAsync();

        Task<UserRoleResponseDto> AddUserRoleAsync(CreateUserRoleDto roleDto);

        Task<UserRoleResponseDto> UpdateUserRoleAsync(int id, CreateUserRoleDto roleDto);

        Task<UserRoleResponseDto?> GetUserRoleByIdAsync(int id);

        Task<bool> DeleteUserRoleAsync(int id);
    }
}
}
