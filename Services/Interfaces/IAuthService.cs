using FoodApp.Dtos.Users;

namespace FoodApp.Services.Interfaces
{     
        public interface IAuthService
        {
            Task<LoginResponseDto> LoginAsync(LoginRequestDto loginDto);
        }
    }
