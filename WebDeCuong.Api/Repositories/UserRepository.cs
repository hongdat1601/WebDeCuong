using Microsoft.AspNetCore.Identity;
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
