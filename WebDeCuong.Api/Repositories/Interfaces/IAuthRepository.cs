using WebDeCuong.Api.Models;

namespace WebDeCuong.Api.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        Task<ResponseModel> RegisterAdmin(RegisterModel model);
        Task<ResponseModel> Login(LoginModel model);
    }
}
