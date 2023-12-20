using DbConnect.Entities;
using LoginForChat.Dto;
using LoginForChat.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LoginForChat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpPost(Name = "user")]
        public async Task<User> Post([FromBody] UserDto userDTO)
        {
            var user = await _userService.RegisterUser(userDTO.username, userDTO.password);
            return user;
        }

        [HttpGet(Name = "user")]
        public async Task<User?> Get(int userID)
        {
            var user = await _userService.DetailUser(userID);
            return user;
        }
    }
}
