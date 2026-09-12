using FoodApp.Dtos.Users;
using System.Collections;

namespace FoodApp.Services.Interfaces
{
    public interface IUserService
    {
        
        Task<IEnumerable<UserResponseDto>> GetAllUserAsync();

        Task<UserResponseDto> AddUserAsync(CreateUserDto userDto);

        Task<UserResponseDto> UpdateUserAsync(CreateUserDto userDto);

        Task<UserResponseDto?> GetUserByIdAsync(int id);

        Task<bool> DeleteUserAsync(int id);
    }
}
