using HS.Domain.Core.Contracts.ApplicationService;
using HS.EndPoints.RazorPages.ShopUI.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HS.Domain.Core.Contracts.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using HS.Domain.Core.Entities;
using System.Security.Claims;
using HS.Domain.Core.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private readonly IApplicationUserApplicationService _userApplicationService;

        public UserViewModel UserViewModel = new UserViewModel();
        private readonly IMapper _mapper;


        public ProfileModel(IMapper mapper,IApplicationUserApplicationService userApplicationService)
        {
            _mapper = mapper;
            _userApplicationService = userApplicationService;
        }

        public async Task<IActionResult> OnPost(UserViewModel model)
        {
            await _userApplicationService.Update(_mapper.Map(model, new UserDto()));
            return LocalRedirect("/Admin/Profile/");
        }

        public async Task OnGet()
        {
            UserViewModel = _mapper.Map(await _userApplicationService.Get(), UserViewModel);
        }
    }
}