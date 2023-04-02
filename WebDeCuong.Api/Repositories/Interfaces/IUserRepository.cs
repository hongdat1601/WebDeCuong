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
        UserModel GetById(string email);
        Task<ResponseModel> AddUser(UserModel user);
        Task<ResponseModel> UpdateUser(UserModel user);
        Task<ResponseModel> DeleteUser(string email);
    }
}
