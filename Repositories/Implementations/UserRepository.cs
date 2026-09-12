using FoodApp.Data;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {

        public readonly FoodAppDbContext _DbContext;
        public UserRepository(FoodAppDbContext dbContext) 
        {
            _DbContext = dbContext;
        }
        public async Task<IEnumerable<Users>> GetUsersAsync()
        {
            return await _DbContext.Users.ToListAsync();
        }

        public async Task<Users> AddUserAsync(Users user)
        {
            await _DbContext.Users.AddAsync(user);
            await _DbContext.SaveChangesAsync();

            return user;
        }

        public async Task<Users> UpdateUserAsync(Users user)
        {
            _DbContext.Users.Update(user);

            await _DbContext.SaveChangesAsync();

            return user;
        }

        public async Task<Users?> GetUserByIdAsync(int id)
        {
            return await _DbContext.Users
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public Task<bool> DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
