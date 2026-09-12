using FoodApp.Dtos.Users;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;
using FoodApp.Services.Interfaces;

namespace FoodApp.Services.Implementations
{
    public class UserService : IUserService
    {
        public readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET ALL USERS
        public async Task<IEnumerable<UserResponseDto>> GetAllUserAsync()
        {
            var users = await _userRepository.GetUsersAsync();

            return users.Select(s => new UserResponseDto
            {
                Id = s.Id,
                FirstName = s.FirstName,
                MiddleName = s.MiddleName,
                LastName = s.LastName,
                UserName = s.UserName,
                Password = s.Password,
                MobileNo = s.MobileNo,
                Email = s.Email,
                Address = s.Address,
                UserRoleId = s.UserRoleId,
                LoginAttempt = s.LoginAttempt,
                IsEnable = s.IsEnable,

                IsActive = s.IsActive,
                CreatedBy = s.CreatedBy,
                CreatedDate = s.CreatedDate,
                UpdatedBy = s.UpdatedBy,
                UpdatedDate = s.UpdatedDate
            });
        }


        // ADD USER
        public async Task<UserResponseDto> AddUserAsync(CreateUserDto userDto)
        {
            var user = new Users
            {
                FirstName = userDto.FirstName,
                MiddleName = userDto.MiddleName,
                LastName = userDto.LastName,
                UserName = userDto.UserName,
                Password = userDto.Password,
                MobileNo = userDto.MobileNo,
                Email = userDto.Email,
                Address = userDto.Address,
                IsEnable = userDto.IsEnable,

                IsActive = userDto.IsActive,
                CreatedBy = userDto.CreatedBy,
                CreatedDate = DateTime.Now
            };

            var createdUser = await _userRepository.AddUserAsync(user);

            return new UserResponseDto
            {
                Id = createdUser.Id,
                FirstName = createdUser.FirstName,
                MiddleName = createdUser.MiddleName,
                LastName = createdUser.LastName,
                UserName = createdUser.UserName,
                MobileNo = createdUser.MobileNo,
                Email = createdUser.Email,
                Address = createdUser.Address,
                UserRoleId = createdUser.UserRoleId,
                LoginAttempt = createdUser.LoginAttempt,
                IsEnable = createdUser.IsEnable,

                IsActive = createdUser.IsActive,
                CreatedBy = createdUser.CreatedBy,
                CreatedDate = createdUser.CreatedDate
            };
        }


        // UPDATE USER
        public async Task<UserResponseDto> UpdateUserAsync(CreateUserDto userDto)
        {
            var user = new Users
            {
                Id = userDto.Id,
                FirstName = userDto.FirstName,
                MiddleName = userDto.MiddleName,
                LastName = userDto.LastName,
                UserName = userDto.UserName,
                Password = userDto.Password,
                MobileNo = userDto.MobileNo,
                Email = userDto.Email,
                Address = userDto.Address,
                IsEnable = userDto.IsEnable,
                IsActive = userDto.IsActive
            };

            var updatedUser = await _userRepository.UpdateUserAsync(user);

            return new UserResponseDto
            {
                Id = updatedUser.Id,
                FirstName = updatedUser.FirstName,
                MiddleName = updatedUser.MiddleName,
                LastName = updatedUser.LastName,
                UserName = updatedUser.UserName,
                Password = updatedUser.Password,
                MobileNo = updatedUser.MobileNo,
                Email = updatedUser.Email,
                Address = updatedUser.Address,
                UserRoleId = updatedUser.UserRoleId,
                LoginAttempt = updatedUser.LoginAttempt,
                IsEnable = updatedUser.IsEnable,

                IsActive = updatedUser.IsActive,
                CreatedBy = updatedUser.CreatedBy,
                CreatedDate = updatedUser.CreatedDate,
                UpdatedBy = updatedUser.UpdatedBy,
                UpdatedDate = updatedUser.UpdatedDate
            };
        }
        public async Task<UserResponseDto?> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);

            if (user == null)
                return null;

            return new UserResponseDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                UserName = user.UserName,
                Password = user.Password,
                MobileNo = user.MobileNo,
                Email = user.Email,
                Address = user.Address,
                UserRoleId = user.UserRoleId,
                LoginAttempt = user.LoginAttempt,
                IsEnable = user.IsEnable,

                IsActive = user.IsActive,
                CreatedBy = user.CreatedBy,
                CreatedDate = user.CreatedDate,
                UpdatedBy = user.UpdatedBy,
                UpdatedDate = user.UpdatedDate
            };
        }

        public Task<bool> DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}