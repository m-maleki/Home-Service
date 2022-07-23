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
        Task<IdentityResult> Create(ApplicationUserDto command);
        Task<SignInResult> Login(ApplicationUserDto command);
        Task<List<ApplicationUserDto>> GetAll();

    }
}
