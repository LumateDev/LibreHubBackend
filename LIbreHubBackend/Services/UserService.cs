using LibreHub.Models;
using LIbreHubBackend.Domain;
using LIbreHubBackend.Interfaces;

namespace LIbreHubBackend.Services
{
    public class UserService : IUserService
    {
        private readonly ILogger _logger;
        private readonly UserRepository _userRepository;

        public UserService(ILoggerFactory loggerFactory, UserRepository userRepository)
        {
            _logger = loggerFactory.CreateLogger("UserService");
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserModel>> GetUsersAsync()
        {
            try
            {
                var userDtos = await _userRepository.GetUsersAsync();
                return userDtos.Select(dto => dto.ToModel());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting users!");
                return Enumerable.Empty<UserModel>();
            }
        }
    }
}
