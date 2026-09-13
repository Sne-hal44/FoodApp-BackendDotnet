using System;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.Dtos.Login;
using FoodApp.Repositories.Interfaces;
using FoodApp.Services.Interfaces;

namespace FoodApp.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        // Reusing your existing user repository here!
        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<LoginResponseDto> LoginAsync(LoginRequestDto loginDto)
        {
            // 1. Get all users from the existing repository method
            var users = await _userRepository.GetUsersAsync();

            // 2. Find a user matching both Username and Password
            // Note: Since this is basic practice, we are matching plain-text passwords.
            var matchedUser = users.FirstOrDefault(u =>
                u.UserName.Equals(loginDto.UserName, StringComparison.OrdinalIgnoreCase) &&
                u.Password == loginDto.Password);

            // 3. Check if user was found and if their account is enabled
            if (matchedUser == null)
            {
                return new LoginResponseDto
                {
                    IsValid = false,
                    Message = "Invalid username or password."
                };
            }

            if (!matchedUser.IsEnable)
            {
                return new LoginResponseDto
                {
                    IsValid = false,
                    Message = "Your account is disabled. Please contact support."
                };
            }

            // 4. Return successful login details
            return new LoginResponseDto
            {
                IsValid = true,
                Message = $"Welcome back, {matchedUser.FirstName}! Login successful."
            };
        }
    }
}
