using FoodApp.Models;

namespace FoodApp.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<Users>> GetUsersAsync();

        Task<Users?> GetUserByIdAsync(int id);

        Task<Users> AddUserAsync(Users user);

        Task<Users> UpdateUserAsync(Users user);

        Task<bool> DeleteUserAsync(int id);
    }
}
