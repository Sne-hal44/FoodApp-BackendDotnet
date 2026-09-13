using FoodApp.Dtos.Login;

namespace FoodApp.Services.Interfaces
{     
        public interface IAuthService
        {
            Task<LoginResponseDto> LoginAsync(LoginRequestDto loginDto);
        }
    }
