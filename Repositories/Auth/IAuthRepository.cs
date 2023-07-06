using dotnet_mywallet.Models;

namespace dotnet_mywallet.Repositories.Auth
{
    public interface IAuthRepository
    {
        Task<int> InsertOne(User user);
        Task<User?> FindByEmail(string email);
    }
}