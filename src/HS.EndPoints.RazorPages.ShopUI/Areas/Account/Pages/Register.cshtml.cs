using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.EndPoints.RazorPages.ShopUI.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.ShopUI.Areas.Account.Pages
{
    [Area("Account")]
    public class RegisterModel : PageModel
    {
        private readonly IApplicationUserApplicationService _applicationUserApplicationService;
        private readonly IMapper _mapper;

        public RegisterModel(IMapper mapper,
            IApplicationUserApplicationService applicationUserApplicationService)
        {
            _mapper = mapper;
            _applicationUserApplicationService = applicationUserApplicationService;
        }

        public async Task<IActionResult> OnPostCreate(RegisterViewModel model,CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                var result = await _applicationUserApplicationService.Create(_mapper.Map(model, new ApplicationUserDto()), cancellationToken);
                if (result.Succeeded)
                {
                    return LocalRedirect("/Account/Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, item.Description);
                        return default;
                    }
                }
            }
            return default;
        }
    }
}
