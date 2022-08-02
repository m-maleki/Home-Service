using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.UI.Pages
{
    public class HomeServiceCategoryModel : PageModel
    {
        private readonly IHomeServiceSubCategoryApplicationService _homeServiceSubCategoryApplicationService;
        public List<HomeServiceSubCategoryViewModel> homeServiceSubCategory;
        private readonly IMapper _mapper;

        public HomeServiceCategoryModel(IHomeServiceSubCategoryApplicationService homeServiceSubCategoryApplicationService,
            IMapper mapper)
        {
            _homeServiceSubCategoryApplicationService = homeServiceSubCategoryApplicationService;
            _mapper = mapper;
        }

        public async Task OnGet(int id,CancellationToken cancellationToken)
        {
            homeServiceSubCategory = _mapper.Map(await _homeServiceSubCategoryApplicationService.GetAllBy(id, cancellationToken),
                new List<HomeServiceSubCategoryViewModel>());
        }
    }
}
