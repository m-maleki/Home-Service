using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.EndPoints.RazorPages.ShopUI.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly IExpertApplicationService _expertApplicationService ;
        private readonly ICityApplicationService _cityApplicationService ;
        public SelectList Cities { get; set; }

        private readonly IMapper _mapper;

        public ProfileModel(IExpertApplicationService expertApplicationService,
            IMapper mapper,
            ICityApplicationService cityApplicationService)
        {
            _expertApplicationService = expertApplicationService;
            _mapper = mapper;
            _cityApplicationService = cityApplicationService;
        }

        public UserViewModel UserViewModel=new UserViewModel();

        public async Task<IActionResult> OnPost(UserViewModel model)
        {
            var user = new ExpertDto();
            _mapper.Map(model, user);
            await _expertApplicationService.Update(user);
            return LocalRedirect("/Admin/Profile/");
        }

        public async Task OnGet()
        {
            var result = await _cityApplicationService.Get();
            Cities = new SelectList(result, "Id", "Name");
            var user = await _expertApplicationService.Get(User.Identity.Name);
            _mapper.Map(user, UserViewModel);   
        }
    }
}