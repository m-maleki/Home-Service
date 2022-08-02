using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos.ApplicationUsers;
using HS.Domain.Core.Entities;
using HS.EndPoints.RazorPages.ShopUI.Model;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.Entity;
using System.Web;

namespace HS.EndPoints.RazorPages.ShopUI.Areas.Account.Pages
{

    [Area("Account")]
    public class LoginModel : PageModel
    {

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly SeedIdentityData _seedIdentityData;

        private readonly IApplicationUserApplicationService _applicationUserApplicationService;
        private readonly IMapper _mapper;

        public LoginModel(SignInManager<ApplicationUser> signInManager,
            SeedIdentityData seedIdentityData,
            IApplicationUserApplicationService applicationUserApplicationService,
            IMapper mapper)
        {
            _signInManager = signInManager;
            _seedIdentityData = seedIdentityData;
            _applicationUserApplicationService = applicationUserApplicationService;
            _mapper = mapper;
        }

        public async Task OnGet()
        {
             await _seedIdentityData.Inistialize();
        }

        public async Task OnPostLogout()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IActionResult> OnPostLogin(LoginViewModel model,CancellationToken cancellationToken )
        {
           

            if (ModelState.IsValid)
            {
                var result =  await _applicationUserApplicationService.Login(_mapper.Map(model, new ApplicationUserDto()),cancellationToken);
                if (result.Succeeded)
                {
                    return LocalRedirect("~/Admin/");
                }
                ModelState.AddModelError(string.Empty, "نام کاربری یا کلمه عبور اشتباه است *");
            }
            return default;
        }
        }
}
