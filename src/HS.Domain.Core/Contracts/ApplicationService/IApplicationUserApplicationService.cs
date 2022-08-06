using HS.Domain.Core.Dtos;
using HS.Domain.Core.Dtos.ApplicationUsers;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.ApplicationService
{
    public interface IApplicationUserApplicationService
    {
        Task<IdentityResult> Create(ApplicationUserDto command, CancellationToken cancellationToken);
        Task<SignInResult> Login(ApplicationUserDto command, CancellationToken cancellationToken);
        Task<List<ApplicationUserDto>> GetAll(CancellationToken cancellationToken);
        public Guid GetUserId(CancellationToken cancellationToken);
        Task Update(UserDto dto, CancellationToken cancellationToken);
        Task<UserDto> Get(CancellationToken cancellationToken);
        Task SetConfirmKey(string emailAddress, Guid confirmKey);
        Task<bool> confirmEmail(string token);

    }
}
