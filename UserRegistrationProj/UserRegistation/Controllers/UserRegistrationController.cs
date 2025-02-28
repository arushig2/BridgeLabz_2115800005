using BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;
using System.Collections.Generic;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly UserRegistrationBL _userRegistrationBL;

        public UserRegistrationController(UserRegistrationBL userRegistrationBL)
        {
            _userRegistrationBL = userRegistrationBL;
        }

        [HttpPost]
        public IActionResult RegisterUser([FromBody] UserDto user)
        {
            if (user == null)
            {
                return BadRequest("User data is required.");
            }

            var result = _userRegistrationBL.RegisterUser(user);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            List<UserDto> users = _userRegistrationBL.GetAllUsers();
            return Ok(users);
        }
    }
}
