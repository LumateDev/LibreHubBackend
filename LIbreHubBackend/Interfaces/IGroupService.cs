using LIbreHubBackend.Models;

namespace LIbreHubBackend.Interfaces
{
    public interface IGroupService
    {
        Task<IEnumerable<GroupModel>> GetGroupsAsync();
    }
}
