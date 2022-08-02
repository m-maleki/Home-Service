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


        public async Task OnGet(CancellationToken cancellationToken)
        {
            HomeServices = _mapper.Map(await _homeServiceApplicationService.Get(cancellationToken) , new List<HomeServiceViewModel>()) ;
            homeServiceSubCategories = new SelectList(await _homeServiceSubCategoryApplicationService.GetAll(cancellationToken), "Id", "Name");
        }

        public async Task<IActionResult> OnPostCreate(HomeServiceViewModel model,CancellationToken cancellationToken)
        {
            await _homeServiceApplicationService.Create(_mapper.Map(model,new HomeServiceDto()), cancellationToken);
            return LocalRedirect("/Admin/HomeServices");
        }

        public async Task<IActionResult> OnPostActive(int id,CancellationToken cancellationToken)
        {
            await _homeServiceApplicationService.Active(id, cancellationToken);
            return LocalRedirect("/Admin/HomeServices");
        }
        public async Task<IActionResult> OnPostDeActive(int id,CancellationToken cancellationToken)
        {
            await _homeServiceApplicationService.DeActive(id, cancellationToken);
            return LocalRedirect("/Admin/HomeServices");
        }
    }
}