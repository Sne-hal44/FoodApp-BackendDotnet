namespace FoodApp.Dtos.Users
{
    public class LoginResponseDto
    {
        public bool IsValid { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
