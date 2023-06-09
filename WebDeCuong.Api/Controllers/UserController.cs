﻿using Microsoft.AspNetCore.Authorization;
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
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var users = await _userRepository.GetAllUser();
                return Ok(users);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateUser([FromBody] UserModel model)
        {
            var result = await _userRepository.UpdateUser(model);
            if (result.Status.CompareTo(Status.Error) == 0)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPut("ResetPassword")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordModel model)
        {
            var result = await _userRepository.ResetPassword(model.Email);
            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPut("ChangePassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordModel model)
        {
            var result = await _userRepository.ChangePassword(model);

            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> AddUser([FromBody]UserModel user)
        {
            var result = await _userRepository.AddUser(user);

            if (result.Status.CompareTo(Status.Error) == 0)
                return BadRequest(result);
            return Ok(result);
        }


        [Authorize(Roles="Admin")]
        [HttpDelete]
        public async Task<IActionResult> DeleteUser([FromQuery] string email)
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
            
    }
}
