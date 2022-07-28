using AutoMapper;
using HS.Domain.ApplicationServices;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    public class HomeServicesModel : PageModel
    {
        private readonly IHomeServiceApplicationService _homeServiceApplicationService;
        private readonly IHomeServiceSubCategoryApplicationService _homeServiceSubCategoryApplicationService;
        private readonly IMapper _mapper;

        public HomeServicesModel(IHomeServiceApplicationService homeServiceApplicationService,
            IHomeServiceSubCategoryApplicationService homeServiceSubCategoryApplicationService,
            IMapper mapper)
        {
            _homeServiceApplicationService = homeServiceApplicationService;
            _homeServiceSubCategoryApplicationService = homeServiceSubCategoryApplicationService;
            _mapper = mapper;
        }

        public List<HomeServiceViewModel> HomeServices { get; set; }
        public SelectList  homeServiceSubCategories { get; set; }


        public async Task OnGet()
        {
            HomeServices = _mapper.Map(await _homeServiceApplicationService.Get() , new List<HomeServiceViewModel>()) ;
            homeServiceSubCategories = new SelectList(await _homeServiceSubCategoryApplicationService.GetAll(), "Id", "Name");
        }

        public async Task<IActionResult> OnPostCreate(HomeServiceViewModel model)
        {
            await _homeServiceApplicationService.Create(_mapper.Map(model,new HomeServiceDto()));
            return LocalRedirect("/Admin/HomeServices");
        }

        public async Task<IActionResult> OnPostActive(int id)
        {
            await _homeServiceApplicationService.Active(id);
            return LocalRedirect("/Admin/HomeServices");
        }
        public async Task<IActionResult> OnPostDeActive(int id)
        {
            await _homeServiceApplicationService.DeActive(id);
            return LocalRedirect("/Admin/HomeServices");
        }
    }
}