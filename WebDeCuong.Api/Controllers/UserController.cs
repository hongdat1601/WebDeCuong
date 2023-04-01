using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebDeCuong.Api.Cons;
using WebDeCuong.Api.Models;
using WebDeCuong.Api.Repositories.Interfaces;

namespace WebDeCuong.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpPost("register")]
        public async Task<ActionResult> Register([FromForm, FromBody] RegisterModel model)
        {
            var result = await _userRepository.Register(model);

            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("register-admin")]
        public async Task<ActionResult> RegisterAdmin([FromForm, FromBody] RegisterModel model)
        {
            var result = await _userRepository.RegisterAdmin(model);

            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromForm, FromBody]LoginModel model)
        {
            var result = await _userRepository.Login(model);

            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result);

            return Ok(result);
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
        [HttpGet("Id")]
        public IActionResult GetUserById(string id)
        {
            try
            {
                var data = _userRepository.GetById(id);
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
        public IActionResult AddUser(UserModel user)
        {
            try
            {
                return Ok(_userRepository.AddUser(user));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
