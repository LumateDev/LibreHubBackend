﻿using LibreHub.Models;
using LIbreHubBackend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LIbreHubBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("/getUsers")]
        public async Task<IActionResult> GetUsersAsync()
        {
            var users = await _userService.GetUsersAsync();
            return Ok(users);
        }

        [HttpPost("/createUser")]
        public async Task<IActionResult> CreateUserAsync([FromBody] UserModel userModel)
        {
            var createdUser = await _userService.CreateUserAsync(userModel);
            return Ok(createdUser);
        }
    }
}
