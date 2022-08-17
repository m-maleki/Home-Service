using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
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
        private readonly IEmailService _emailSender;
        public ApplicationUserService(IApplicationUserRepository applicationRepository,
            IHttpContextAccessor httpContext,
            UserManager<ApplicationUser> userManager,
            IEmailService emailSender)
        {
            _applicationRepository = applicationRepository;
            _httpContext = httpContext;
            _userManager = userManager;
            _emailSender = emailSender;
        }


        public Guid GetUserId(CancellationToken cancellationToken)
        {
            ClaimsPrincipal currentUser = _httpContext.HttpContext.User;
            return new Guid(currentUser.FindFirst(ClaimTypes.NameIdentifier).Value);
        }

        public async Task<IdentityResult> Create(ApplicationUserDto command, CancellationToken cancellationToken)
          => await _applicationRepository.Create(command, cancellationToken);

        public async Task<SignInResult> Login(ApplicationUserDto command, CancellationToken cancellationToken)
         => await _applicationRepository.Login(command, cancellationToken);

        public async Task<List<ApplicationUserDto>> GetAll(CancellationToken cancellationToken)
          => await _applicationRepository.GetAll(cancellationToken);

        public async Task SetConfirmKey(string emailAddress, Guid confirmKey)
          => await _applicationRepository.SetConfirmKey(emailAddress, confirmKey);

        public async Task ActiveEmailConfirm(string emailAddress)
          => await _applicationRepository.ActiveEmailConfirm(emailAddress);

        public async Task<bool> EmailIsConfirmed(string emailAddress)
         => await _applicationRepository.EmailIsConfirmed(emailAddress);

        public async Task DeActiveEmailConfirm(string emailAddress)
           => await _applicationRepository.DeActiveEmailConfirm(emailAddress);

        public async Task<bool> IsExist(string emailAddress)
         => await _applicationRepository.IsExist(emailAddress);

        public async Task<bool> confirmEmail(string token)
         => await _applicationRepository.confirmEmail(token);
        public bool IsInRole(string role)
         => _httpContext.HttpContext.User.IsInRole(role);

        public async Task<Guid> SendEmailActivation(string emailAddress, CancellationToken cancellationToken)
        {
            var confirmKey = Guid.NewGuid();
            var protocol = _httpContext.HttpContext.Request.Scheme;
            string url = protocol + "://" + _httpContext.HttpContext.Request.Host.Value + "/Account/emailConfirmation";
            string message = $"<a href={url}?confirmKey={confirmKey}>برای فعالسازی بر روی این لینک کلیک کنید </a>";
            await _emailSender.SendEmailAsync(emailAddress, "ایمیل فعالسازی", message);
            return confirmKey;
        }

        public async Task<string> getRole(CancellationToken cancellationToken)
        {
            var result = await _userManager.GetRolesAsync(await _userManager.FindByEmailAsync(_httpContext.HttpContext.User.Identity!.Name));
            return result.First();
        }

    }
}
