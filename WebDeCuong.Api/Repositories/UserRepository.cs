﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public UserRepository(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
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

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, model.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

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

        public async Task<ResponseModel> Register(RegisterModel model)
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

            if (!await _roleManager.RoleExistsAsync("User"))
                await _roleManager.CreateAsync(new IdentityRole("User"));

            await _userManager.AddToRoleAsync(user, "User");
            responseModel.Status = Status.Success;
            responseModel.Message = "User created successfully.";

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

            if (!await _roleManager.RoleExistsAsync("Admin"))
                await _roleManager.CreateAsync(new IdentityRole("Admin"));

            await _userManager.AddToRoleAsync(user, "Admin");
            responseModel.Status = Status.Success;
            responseModel.Message = "User created successfully.";

            return responseModel;
        }
        public List<UserModel> GetAllUser()
        {
            var users = _userManager.Users.Select(user => new UserModel
            {   
                Username = user.UserName,
               
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Avatar = user.Avatar,
                Faculty = user.Faculty,
                FullName = user.FullName

            });
            return users.ToList();
        }
        public UserModel GetById(string email)
        {
            var user = _userManager.Users.SingleOrDefault(user => user.Email == email);
            if (user !=null)
            {
                return new UserModel
                {
                    Username = user.UserName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    Avatar = user.Avatar,
                    Faculty = user.Faculty,
                    FullName = user.FullName
                };
            }
            return null;
        }
        public async Task<ResponseModel> AddUser(UserModel user)
        {
            var responseModel = new ResponseModel();
            var _user = new ApplicationUser
            {
                UserName = user.Email,
                Email = user.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                PhoneNumber = user.PhoneNumber,
                Avatar = user.Avatar,
                Faculty = user.Faculty,
                FullName = user.FullName

            };
            var result = await _userManager.CreateAsync(_user, "123456aA@");
            if (!result.Succeeded)
            {
                responseModel.Status = Status.Error;
                responseModel.Message = "";
                return responseModel;
            }
            await _roleManager.CreateAsync(new IdentityRole("User"));
            await _userManager.AddToRoleAsync(_user, "User");
            responseModel.Status = Status.Success;
            responseModel.Message = "User created successfully.";

            return responseModel;

        }
        public async Task<ResponseModel> UpdateUser(UserModel user)
        {
            var responseModel = new ResponseModel();
            var _user = _userManager.Users.SingleOrDefault(_user => _user.Email == user.Email);
            if (_user != null)
            {
                _user.UserName = user.Username;
                _user.PhoneNumber = user.PhoneNumber;
                _user.Avatar = user.Avatar;
                _user.Faculty = user.Faculty;
                _user.FullName = user.FullName;
                var result = await _userManager.UpdateAsync(_user);
                if (!result.Succeeded)
                {
                    responseModel.Status = Status.Error;
                    responseModel.Message = "";
                    return responseModel;
                }
                responseModel.Status = Status.Success;
                responseModel.Message = "User Update successfully.";
                return responseModel;


            }
            responseModel.Status = Status.Error;
            responseModel.Message = "Not Found User";
            return responseModel;



        }
        public async Task<ResponseModel> DeleteUser(string email)
        {
            var responseModel = new ResponseModel();
            var _user = _userManager.Users.SingleOrDefault(_user => _user.Email == email);
            if(_user != null)
            {
                var result = await _userManager.DeleteAsync(_user);
                if (!result.Succeeded)
                {
                    responseModel.Status = Status.Error;
                    responseModel.Message = "";
                    return responseModel;
                }
                responseModel.Status = Status.Success;
                responseModel.Message = "User Delete successfully.";
                return responseModel;
            }
            responseModel.Status = Status.Success;
            responseModel.Message = "User Not Found.";
            return responseModel;
        }
       
    }
}
