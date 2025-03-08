using LIbreHubBackend.Domain;

namespace LibreHub.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public UserDTO ToDTO() => new UserDTO
        {
            Id = UserId,
            Name = Name,
            Email = Email,
            Password_Hash = PasswordHash
        };
    }
}
