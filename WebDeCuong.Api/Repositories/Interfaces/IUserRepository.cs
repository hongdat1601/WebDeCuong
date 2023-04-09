using Microsoft.AspNetCore.Mvc;
using WebDeCuong.Api.Models;

namespace WebDeCuong.Api.Repositories.Interfaces
{
    public interface IUserRepository
    {
        List<UserModel> GetAllUser();
        UserModel GetById(string email);
        Task<ResponseModel> AddUser(UserModel user);
        Task<ResponseModel> UpdateUser(UpdateUserModel model);
        Task<ResponseModel> DeleteUser(string email);
        Task<ResponseModel> GetCurrentUserInfo();
        Task<ResponseModel> ChangePassword(ChangePasswordModel model);
    }
}
