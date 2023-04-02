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
    }
}
