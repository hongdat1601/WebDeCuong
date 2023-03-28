using WebDeCuong.Api.Models;

namespace WebDeCuong.Api.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<ResponseModel> Register(RegisterModel model);
        Task<ResponseModel> RegisterAdmin(RegisterModel model);
        Task<ResponseModel> Login(LoginModel model);
    }
}
