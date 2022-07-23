using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos.ApplicationUsers;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.ApplicationServices
{
    public class ApplicationUserApplicationService : IApplicationUserApplicationService
    {
        private readonly IApplicationUserService _applicationUserService;

        public ApplicationUserApplicationService(IApplicationUserService applicationUserService)
        {
            _applicationUserService = applicationUserService;
        }

        public async Task<IdentityResult> Create(ApplicationUserDto command)
            =>await _applicationUserService.Create(command);

        public Task<List<ApplicationUserDto>> GetAll()
        => _applicationUserService.GetAll();

        public Task<SignInResult> Login(ApplicationUserDto command)
        => _applicationUserService.Login(command);
    }
}
