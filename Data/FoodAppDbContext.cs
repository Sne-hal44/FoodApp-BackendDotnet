using FoodApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.Data
{
    public class FoodAppDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; } = null;
        public DbSet<UserRole> UserRole { get; set; } = null;

        public FoodAppDbContext(DbContextOptions<FoodAppDbContext> options) : base(options)
        {

        }


    }
}
