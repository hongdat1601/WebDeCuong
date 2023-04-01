using Microsoft.AspNetCore.Mvc;
using WebDeCuong.Api.Models;

namespace WebDeCuong.Api.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<ResponseModel> Register(RegisterModel model);
        Task<ResponseModel> RegisterAdmin(RegisterModel model);
        Task<ResponseModel> Login(LoginModel model);
        List<UserModel> GetAllUser();
        UserModel GetById(string id);
        UserModel AddUser(UserModel user);
    }
}
