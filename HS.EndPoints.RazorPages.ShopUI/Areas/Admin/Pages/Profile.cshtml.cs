using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Entities;
using HS.EndPoints.RazorPages.ShopUI.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IExpertApplicationService _expertApplicationService ;
        private readonly IMapper _mapper;

        public ProfileModel(UserManager<ApplicationUser> userManager,
            IExpertApplicationService expertApplicationService,
            IMapper mapper)
        {
            _userManager = userManager;
            _expertApplicationService = expertApplicationService;
            _mapper = mapper;
        }

        public UserViewModel UserViewModel=new UserViewModel();

        public async Task OnPost(UserViewModel model)
        {
        }

        public async Task OnGet()
        {
            _mapper.Map(_expertApplicationService.Get(User.Identity.Name), UserViewModel);   
        }
    }
}