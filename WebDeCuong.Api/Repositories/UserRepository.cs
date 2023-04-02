using Microsoft.AspNetCore.Identity;
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

        public UserRepository() 
        {
            
        }

    }
}
