
namespace IdentityProject
{
    public interface IUserAuthenticationService
    {
        Task<bool> ValidateUserAsync(UserLoginDto loginDto);
        Task<string> CreateTokenAsync();
        Task<bool> LockUser(string email);
        Task<bool> UnLockUser(string email);
    }
}
