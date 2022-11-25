using Microsoft.AspNetCore.Identity;
using ProyectoWebN.Data.Entity;
using ProyectoWebN.Models;

namespace ProyectoWebN.Data.Helper
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

    }
}
