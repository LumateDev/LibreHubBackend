using LIbreHubBackend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LIbreHubBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        private readonly IGroupService _groupService;

        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;
        }

        [HttpGet("/getGroups")]
        public async Task<IActionResult> GetGroupsAsync()
        {
            var groups = await _groupService.GetGroupsAsync();
            return Ok(groups);
        }
    }
}
