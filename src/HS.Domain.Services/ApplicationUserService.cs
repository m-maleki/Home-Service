using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos.ApplicationUsers;
using HS.Domain.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly IApplicationUserRepository _applicationRepository;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUserService(IApplicationUserRepository applicationRepository,
            IHttpContextAccessor httpContext,
            UserManager<ApplicationUser> userManager)
        {
            _applicationRepository = applicationRepository;
            _httpContext = httpContext;
            _userManager = userManager;
        }
        public async Task<IdentityResult> Create(ApplicationUserDto command)
            => await _applicationRepository.Create(command);
        public async Task<List<ApplicationUserDto>> GetAll()
            => await _applicationRepository.GetAll();

        public Guid GetUserId()
        {
            ClaimsPrincipal currentUser = _httpContext.HttpContext.User;
            return new Guid(currentUser.FindFirst(ClaimTypes.NameIdentifier).Value);
        }

        public async Task<string> getRole()
        {
            var result =  await _userManager.GetRolesAsync(await _userManager.FindByEmailAsync(_httpContext.HttpContext.User.Identity!.Name));
            return result.First();
        }

        public async Task<SignInResult> Login(ApplicationUserDto command)
        => await  _applicationRepository.Login(command);

        public bool IsInRole(string role)
        {
            return _httpContext.HttpContext.User.IsInRole(role);
        }
    }
}
