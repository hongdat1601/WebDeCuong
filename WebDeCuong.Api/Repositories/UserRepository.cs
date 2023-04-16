using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly IHttpContextAccessor _contextAccessor;

        public UserRepository(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration,
            IHttpContextAccessor contextAccessor)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _contextAccessor = contextAccessor;
        }

        public async Task<List<UpdateUserModel>> GetAllUser()
        {
            var users = await _userManager.Users.ToListAsync();

            var results = new List<UpdateUserModel>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                foreach (var role in roles)
                {
                    if (role.CompareTo("User") == 0)
                    {
                        results.Add(new UpdateUserModel
                        {
                            DateOfBirth = user.DateOfBirth.ToString("yyyy-MM-dd"),
                            Email = user.Email!,
                            Faculty = user.Faculty,
                            FullName = user.FullName,
                            Gender = user.Gender,
                            Phone = user.PhoneNumber!,
                            PlaceOfBirth = user.PlaceOfBirth
                        });
                        break;
                    }
                }
            }
            
            return results;
        }

        public UserModel GetById(string email)
        {
            var user = _userManager.Users.SingleOrDefault(user => user.Email == email);
            if (user != null)
            {
                return new UserModel
                {
                    Username = user.UserName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
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

        public async Task<ResponseModel> UpdateUser(UpdateUserModel model)
        {
            var responseModel = new ResponseModel();
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                responseModel.Status = Status.Error;
                responseModel.Message = "User Not Found.";

                return responseModel;
            }

            user.FullName = model.FullName;
            user.Faculty = model.Faculty;
            user.PhoneNumber = model.Phone;
            user.PlaceOfBirth = model.PlaceOfBirth;
            user.Gender = model.Gender;
            user.DateOfBirth = DateTime.Parse(model.DateOfBirth);

            var result = await _userManager.UpdateAsync(user);

            if (!result.Succeeded)
            {
                responseModel.Status = Status.Error;
                responseModel.Message = "";

                foreach (var err in result.Errors)
                {
                    responseModel.Message = responseModel.Message + err.Description + '\n';
                }

                return responseModel;
            }

            responseModel.Status = Status.Success;
            responseModel.Message = "User was successfully updated.";

            return responseModel;
        }

        public async Task<ResponseModel> DeleteUser(string email)
        {
            var responseModel = new ResponseModel();
            var _user = _userManager.Users.SingleOrDefault(_user => _user.Email == email);
            if (_user != null)
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

        public async Task<ResponseModel> GetCurrentUserInfo()
        {
            var responseModel = new ResponseModel();

            var email = _contextAccessor.HttpContext!.User.Claims
                .FirstOrDefault(c => c.Type.CompareTo(ClaimTypes.Email) == 0);

            if (email == null)
            {
                responseModel.Status = Status.Error;
                responseModel.Message = "Token not accepted.";
                return responseModel;
            }

            var user = await _userManager.FindByNameAsync(email.Value);
            if (user == null)
            {
                responseModel.Status = Status.Error;
                responseModel.Message = "User not found.";
                return responseModel;
            }

            var roles = await _userManager.GetRolesAsync(user);

            responseModel.Status = Status.Success;
            responseModel.Result = new
            {
                Faculty = user.Faculty,
                Email = user.Email,
                Phone = user.PhoneNumber,
                PlaceOfBirth = user.PlaceOfBirth,
                DateOfBirth = user.DateOfBirth.ToString("yyyy-MM-dd"),
                Gender = user.Gender,
                FullName = user.FullName,
                Roles = roles[0]
            };
            return responseModel;
        }

        public async Task<ResponseModel> ChangePassword(ChangePasswordModel model)
        {
            var resModel = new ResponseModel();
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                resModel.Status = Status.Error;
                resModel.Message = "User not found.";
                return resModel;
            }

            var changePassRes = await _userManager
                .ChangePasswordAsync(user, model.Password, model.NewPassword);

            if (!changePassRes.Succeeded)
            {
                resModel.Status = Status.Error;
                resModel.Message = "";

                foreach (var err in changePassRes.Errors)
                {
                    resModel.Message = resModel.Message + err.Description + '\n';
                }

                return resModel;
            }

            resModel.Status = Status.Success;
            resModel.Message = "Password was successfully changed.";
            return resModel;
        }

        public async Task<ResponseModel> ResetPassword(string Email)
        {
            var resModel = new ResponseModel();

            var user = await _userManager.FindByEmailAsync(Email);
            if (user == null)
            {
                resModel.Status = Status.Error;
                resModel.Message = "User not found.";

                return resModel;
            }

            PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = ph.HashPassword(user, "123456@Abc");

            var res = await _userManager.UpdateAsync(user);
            if (!res.Succeeded)
            {
                resModel.Status = Status.Error;
                resModel.Message = "";

                foreach (var err in res.Errors)
                {
                    resModel.Message = resModel.Message + err.Description + '\n';
                }

                return resModel;
            }

            resModel.Status = Status.Success;
            resModel.Message = "User password successfuly reseted.";
            return resModel;
        }
    }
}
