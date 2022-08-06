using HS.Domain.Core.Dtos.ApplicationUsers;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IApplicationUserService
    {
        Task<IdentityResult> Create(ApplicationUserDto command, CancellationToken cancellationToken);
        Task<SignInResult> Login(ApplicationUserDto command, CancellationToken cancellationToken);
        Task<List<ApplicationUserDto>> GetAll(CancellationToken cancellationToken);
        public Guid GetUserId(CancellationToken cancellationToken);
        Task<string> getRole(CancellationToken cancellationToken);
        bool IsInRole(string role);
        Task<Guid> SendEmailActivation(string emailAddress, CancellationToken cancellationToken);
        Task SetConfirmKey(string emailAddress, Guid confirmKey);
        Task<bool> confirmEmail(string token);
    }
}
