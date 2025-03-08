using LibreHub.Models;

namespace LIbreHubBackend.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserModel>> GetUsersAsync();
    }
}
