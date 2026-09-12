namespace FoodApp.Dtos.Users
{
    public class CreateUserRoleDto
    {
        public string UserRole { get; set; } = string.Empty;
        public int CreatedBy { get; set; }
    }

  
    public class UserRoleResponseDto
    {
        public int Id { get; set; }
        public string UserRole { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
