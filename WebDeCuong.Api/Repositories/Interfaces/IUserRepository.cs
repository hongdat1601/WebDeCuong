using Microsoft.AspNetCore.Mvc;
using WebDeCuong.Api.Models;

namespace WebDeCuong.Api.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserModel>> GetAllUser();
        Task<ResponseModel> AddUser(UserModel user);
        Task<ResponseModel> UpdateUser(UserModel model);
        Task<ResponseModel> DeleteUser(string email);
        Task<ResponseModel> GetCurrentUserInfo();
        Task<ResponseModel> ChangePassword(ChangePasswordModel model);
        Task<ResponseModel> ResetPassword(string Email);
    }
}
