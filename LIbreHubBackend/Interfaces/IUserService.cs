using LibreHub.Models;

namespace LIbreHubBackend.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserModel>> GetUsersAsync();
        Task<UserModel> CreateUserAsync(UserModel userModel);
    }
}
