using FoodApp.Models;

namespace FoodApp.Repositories.Interfaces
{
    public interface IUserRoleRepository
    {
        Task<IEnumerable<UserRole>> GetUserRoleAsync();

        Task<UserRole?> GetUserRoleByIdAsync(int id);

        Task<UserRole> AddUserRoleAsync(UserRole userRole);

        Task<UserRole> UpdateUserRoleAsync(UserRole userRole);

        Task<bool> DeleteUserRoleAsync(int id);
    }
}
