using BMSClone.DTOs;
using BMSClone.Models;
using BMSClone.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BMSClone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {

        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("/createUser")]
        public async Task<User> createUser(UserDTO userDTO)
        {
            User user = new User();
            user.FirstName = userDTO.FirstName;
            user.LastName = userDTO.LastName;
            user.Email = userDTO.Email;
            user.Password = BCrypt.Net.BCrypt.HashPassword(userDTO.Password);
            return await _userService.createUser(user);

        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok("Hello world");
        }

    }
}
