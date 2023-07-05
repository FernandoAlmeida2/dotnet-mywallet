using dotnet_mywallet.Models;

namespace dotnet_mywallet.Repositories.Auth
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> InsertOne(User user, string password);
        Task<bool> UserExists(string email);
    }
}