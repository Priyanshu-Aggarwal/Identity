using AutoMapper;
using IdentityProject.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace IdentityProject.Repositories.Implementations
{
    public class RegistrationService : IRegistrationService
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        public RegistrationService(IServiceProvider serviceProvider, IMapper mapper)
        {
            _userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            _mapper = mapper;
        }
        public async Task<IdentityResult> RegisterUserAsync(UserRegistrationDto userForRegistration)
        {
            var user = _mapper.Map<User>(userForRegistration);
            var result = await _userManager.CreateAsync(user, userForRegistration.Password);                 
            return result;
        }
    }
}
