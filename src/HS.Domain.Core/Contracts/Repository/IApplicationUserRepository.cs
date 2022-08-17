using HS.Domain.Core.Dtos;
using Microsoft.AspNetCore.Identity;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IApplicationUserRepository
    {
        Task<IdentityResult> Create(ApplicationUserDto command,CancellationToken cancellationToken);
        Task<SignInResult> Login(ApplicationUserDto command, CancellationToken cancellationToken);
        Task<List<ApplicationUserDto>> GetAll(CancellationToken cancellationToken);
        Task SetConfirmKey(string emailAddress,Guid confirmKey);
        Task<bool> confirmEmail(string token);

        Task ActiveEmailConfirm(string emailAddress);
        Task DeActiveEmailConfirm(string emailAddress);
        Task<bool> EmailIsConfirmed(string emailAddress);
        Task<bool> IsExist(string emailAddress);

    }
}
