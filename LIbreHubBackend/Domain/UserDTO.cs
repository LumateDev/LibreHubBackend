using LibreHub.Models;
using LIbreHubBackend.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIbreHubBackend.Domain
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        [Column("password_hash")]
        public string Password_Hash { get; set; }

        public UserModel ToModel() => new UserModel
        {
            UserId = Id,
            Name = Name,
            Email = Email,
            PasswordHash = Password_Hash,
        };
    }
}
