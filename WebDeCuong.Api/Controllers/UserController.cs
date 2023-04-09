using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebDeCuong.Api.Cons;
using WebDeCuong.Api.Models;
using WebDeCuong.Api.Repositories.Interfaces;

namespace WebDeCuong.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_userRepository.GetAllUser());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{email}")]
        public IActionResult GetUserById(string email)
        {
            try
            {
                var data = _userRepository.GetById(email);
                if (data!= null)
                {
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                }    
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        public async Task<ActionResult> AddUser([FromForm, FromBody]UserModel user)
        {
            var result = await _userRepository.AddUser(user);

            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserModel model)
        {
            var result = await _userRepository.UpdateUser(model);
            if(result.Status.CompareTo(Status.Error) == 0)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpDelete("{email}")]
        public async Task<IActionResult> DeleteUser(string email)
        {
            var result = await _userRepository.DeleteUser(email);
            if(result.Status.CompareTo(Status.Error) == 0)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet("getCurrentUserInfo")]
        public async Task<IActionResult> GetCurrentUserInfo()
        {
            var result = await _userRepository.GetCurrentUserInfo();
            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("changePassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordModel model)
        {
            var result = await _userRepository.ChangePassword(model);

            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result);
            return Ok(result);
        }
            
    }
}
