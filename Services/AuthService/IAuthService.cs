using dotnet_mywallet.Dtos.User;
using dotnet_mywallet.Models;

namespace dotnet_mywallet.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> SignUp(User user, string password);
        Task<ServiceResponse<LoginResponseDto>> Login(string email, string password);
    }
}