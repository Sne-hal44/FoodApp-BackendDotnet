using FoodApp.Data;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.Repositories.Implementations
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly FoodAppDbContext _DbContext;

        public UserRoleRepository(FoodAppDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public async Task<IEnumerable<UserRole>> GetUserRoleAsync()
        {
            return await _DbContext.UserRole.ToListAsync();
        } 
        public async Task<UserRole> AddUserRoleAsync(UserRole userRole)
        {
            await _DbContext.UserRole.AddAsync(userRole);
            await _DbContext.SaveChangesAsync();

            return userRole;
        }
                
        public async Task<UserRole> UpdateUserRoleAsync(UserRole userRole)
        {
            _DbContext.UserRole.Update(userRole);
            await _DbContext.SaveChangesAsync();

            return userRole;
        }
        public async Task<UserRole?> GetUserRoleByIdAsync(int id)
        {
            return await _DbContext.UserRole
                .FirstOrDefaultAsync(ur => ur.Id == id);
        }

        
        public async Task<bool> DeleteUserRoleAsync(int id)
        {
            var role = await GetUserRoleByIdAsync(id);
            if (role == null)
            {
                return false; 
            }

            _DbContext.UserRole.Remove(role);
            await _DbContext.SaveChangesAsync();
            return true;
        }


    }
}