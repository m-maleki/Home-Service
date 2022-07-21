using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Dtos.ApplicationUsers;
using HS.Domain.Core.Entities;
using HS.EndPoints.RazorPages.ShopUI.Model;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HS.EndPoints.RazorPages.ShopUI.Areas.Admin.Pages
{

    [Authorize]
    public class UserManagementModel : PageModel
    {
        private readonly IApplicationUserApplicationService _applicationUserApplicationService;
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly IMapper _mapper;
        public List<ApplicationUserViewModel> users;

        public UserManagementModel(UserManager<ApplicationUser> userManager,
            IMapper mapper,
            IApplicationUserApplicationService applicationUserApplicationService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _applicationUserApplicationService = applicationUserApplicationService;
        }


        public async Task OnGet()
        {
            var t = await _applicationUserApplicationService.GetAll();
            users= _mapper.Map(t, users);
        }

        public async Task<IActionResult> OnPostDelete(Guid id)
        {
            var user = await _userManager.Users.Where(x => x.Id == id).SingleAsync();
            await _userManager.DeleteAsync(user);
            return LocalRedirect("/Admin/UserManagement");
        }

        public async Task<IActionResult> OnPostCreate(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _applicationUserApplicationService.Create(_mapper.Map(model, new ApplicationUserDto()));
                if (result.Succeeded)
                {
                    return LocalRedirect("/Admin/UserManagement");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, item.Description);
                        return default;
                    }
                    return LocalRedirect("/Admin/UserManagement");
                }
            }
            return LocalRedirect("/Admin/UserManagement");
        }
    }
}
