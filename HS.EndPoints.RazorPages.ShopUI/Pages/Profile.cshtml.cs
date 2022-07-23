using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Dtos.ApplicationUsers;
using HS.Domain.Core.Entities;
using HS.EndPoints.RazorPages.ShopUI.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.UI.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IApplicationUserApplicationService _applicationUserApplicationService;
        private readonly IMapper _mapper;

        public ProfileModel(SignInManager<ApplicationUser> signInManager,
            IApplicationUserApplicationService applicationUserApplicationService,
            IMapper mapper)
        {
            _signInManager = signInManager;
            _applicationUserApplicationService = applicationUserApplicationService;
            _mapper = mapper;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostLogin(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _applicationUserApplicationService.Login(_mapper.Map(model, new ApplicationUserDto()));
                if (result.Succeeded)
                {
                    return LocalRedirect("/Profile");
                }
                ModelState.AddModelError(string.Empty, "نام کاربری یا کلمه عبور اشتباه است *");
            }
            return default;
        }

        public async Task<IActionResult> OnPostLogout()
        {
            await _signInManager.SignOutAsync();
            return LocalRedirect("/Profile");
        }
    }
}
