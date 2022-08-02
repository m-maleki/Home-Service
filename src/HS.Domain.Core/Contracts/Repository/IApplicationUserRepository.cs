using HS.Domain.Core.Dtos.ApplicationUsers;
using Microsoft.AspNetCore.Identity;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IApplicationUserRepository
    {
        Task<IdentityResult> Create(ApplicationUserDto command,CancellationToken cancellationToken);
        Task<SignInResult> Login(ApplicationUserDto command, CancellationToken cancellationToken);
        Task<List<ApplicationUserDto>> GetAll(CancellationToken cancellationToken);
    }
}
