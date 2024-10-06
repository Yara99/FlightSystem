using FlightSystem.Core.DTO;
using FlightSystem.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        // Constructor Injection for the IUserService
        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost]
        [Route("CreateUser")]
        public void CreateUser(UserDTO userDto)
        {
            _userService.CreateUser(userDto);
        }


        [HttpPut]
        [Route("UpdateUser")]
        public void UpdateUser(UserDTO userDto)
        {
            _userService.UpdateUser(userDto);
        }



        [HttpGet]
        [Route("GetAllUsers")]
        public List<UserDTO> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }


        [HttpGet]
        [Route("getUserById/{id}")]
        public UserDTO GetUserById(int userId)
        {
            return _userService.GetUserById(userId);
        }
    }
}
