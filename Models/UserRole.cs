using System.ComponentModel.DataAnnotations.Schema;

namespace FoodApp.Models
{
    [Table("UserRole")]
    public class UserRole : Common
    {
        public int Id { get; set; }

        [Column("UserRole")]
        public string RoleName { get; set; } = string.Empty;
    }
}