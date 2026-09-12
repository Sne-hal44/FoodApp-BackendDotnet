namespace FoodApp.Dtos.Users
{


    public class UserResponseDto : CommonDto
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

    // Create Parameter
    public class CreateUserDto : CommonDto
    {
        internal int Id;

        public string FirstName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string MobileNo { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public bool IsEnable { get; set; }


    }
    //update Parameter
    public class UpdateUserDto : CommonDto
    {

        public string FirstName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string MobileNo { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public bool IsEnable { get; set; }

    }
}


// Model: User : Common

//DTOs : CreateUserDto - classes input : createUserDto , UpdateUserDto
//output : UserResponseDto

//Api: request /input and Response/output
//requiremnet gathering 