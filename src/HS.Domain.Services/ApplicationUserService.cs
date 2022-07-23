using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos.ApplicationUsers;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly IApplicationUserRepository _applicationRepository;

        public ApplicationUserService(IApplicationUserRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<IdentityResult> Create(ApplicationUserDto command)
            => await _applicationRepository.Create(command);
        public async Task<List<ApplicationUserDto>> GetAll()
            => await _applicationRepository.GetAll();
        public async Task<SignInResult> Login(ApplicationUserDto command)
        => await  _applicationRepository.Login(command);
    }
}
