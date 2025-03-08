using LibreHub.Models;
using LIbreHubBackend.Domain;
using LIbreHubBackend.Interfaces;
using LIbreHubBackend.Models;

namespace LIbreHubBackend.Services
{
    public class GroupService : IGroupService
    {
        private readonly ILogger _logger;
        private readonly GroupRepository _groupRepository;

        public GroupService(ILoggerFactory loggerFactory, GroupRepository groupRepository)
        {
            _logger = loggerFactory.CreateLogger("GroupService");
            _groupRepository = groupRepository;
        }

        public async Task<IEnumerable<GroupModel>> GetGroupsAsync()
        {
            try
            {
                var groupDtos = await _groupRepository.GetGroupsAsync();
                return groupDtos.Select(dto => dto.ToModel());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting groups!");
                return Enumerable.Empty<GroupModel>();
            }
        }
    }
}
