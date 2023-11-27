using Microsoft.AspNetCore.Identity;

namespace IdentityProject.Repositories.Interfaces
{
    public interface IRegistrationService
    {
        Task<IdentityResult> RegisterUserAsync(UserRegistrationDto userForRegistration);
    }
}
