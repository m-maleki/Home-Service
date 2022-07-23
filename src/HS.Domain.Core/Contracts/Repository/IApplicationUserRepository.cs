using HS.Domain.Core.Dtos.ApplicationUsers;
using Microsoft.AspNetCore.Identity;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IApplicationUserRepository
    {
        Task<IdentityResult> Create(ApplicationUserDto command);
        Task<SignInResult> Login(ApplicationUserDto command);
        Task<List<ApplicationUserDto>> GetAll();
    }
}
