﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebDeCuong.Api.Cons;
using WebDeCuong.Api.Models;
using WebDeCuong.Api.Repositories.Interfaces;
using WebDeCuong.Data.Entities;

namespace WebDeCuong.Api.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public AuthRepository(
            UserManager<ApplicationUser> userManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        public async Task<ResponseModel> Login(LoginModel model)
        {
            ResponseModel responseModel = new ResponseModel();

            var userExists = await _userManager.FindByEmailAsync(model.Email);
            if (userExists == null)
            {
                responseModel.Status = Status.Error;
                responseModel.Message = "User not found.";

                return responseModel;
            }

            var checkPass = await _userManager.CheckPasswordAsync(userExists, model.Password);
            if (!checkPass)
            {
                responseModel.Status = Status.Error;
                responseModel.Message = "Wrong password.";

                return responseModel;
            }

            var roles = await _userManager.GetRolesAsync(userExists);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, model.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var expires = DateTime.Now.AddDays(1);

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]!));
            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidIssuer"],
                claims: claims,
                expires: expires,
                signingCredentials: signingCredentials);

            responseModel.Status = Status.Success;
            responseModel.Result = new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                expiredTime = expires,
            };
            return responseModel;
        }

        public async Task<ResponseModel> RegisterAdmin(RegisterModel model)
        {
            var responseModel = new ResponseModel();

            var userExists = await _userManager.FindByEmailAsync(model.Email);
            if (userExists != null)
            {
                responseModel.Status = Status.Error;
                responseModel.Message = "User already exists.";
                return responseModel;
            }

            var user = new ApplicationUser
            {
                Email = model.Email,
                UserName = model.Email,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                responseModel.Status = Status.Error;
                responseModel.Message = "";

                foreach (var error in result.Errors)
                    responseModel.Message = responseModel.Message + error.Description + "\n";

                return responseModel;
            }

            result = await _userManager.AddToRoleAsync(user, "Admin");

            if (!result.Succeeded)
            {
                responseModel.Status = Status.Error;
                responseModel.Message = "";

                foreach (var error in result.Errors)
                    responseModel.Message = responseModel.Message + error.Description + "\n";

                return responseModel;
            }

            responseModel.Status = Status.Success;
            responseModel.Message = "User created successfully.";

            return responseModel;
        }
    }
}
