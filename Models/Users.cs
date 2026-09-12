using System.ComponentModel.DataAnnotations.Schema;

namespace FoodApp.Models
{
    [Table("Users")]
    public class Users : Common
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string MobileNo { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public int UserRoleId { get; set; }

        public int LoginAttempt { get; set; }

        public bool IsEnable { get; set; }

    }
}
