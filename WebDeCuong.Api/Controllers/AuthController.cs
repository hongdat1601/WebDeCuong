using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebDeCuong.Api.Cons;
using WebDeCuong.Api.Models;
using WebDeCuong.Api.Repositories;
using WebDeCuong.Api.Repositories.Interfaces;

namespace WebDeCuong.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("register-admin")]
        public async Task<ActionResult> RegisterAdmin([FromForm] RegisterModel model)
        {
            var result = await _authRepository.RegisterAdmin(model);

            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginModel model)
        {
            var result = await _authRepository.Login(model);

            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
