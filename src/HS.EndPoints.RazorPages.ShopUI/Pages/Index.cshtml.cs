using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Infrastructures.Database.Repos.Ef.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.ShopUI.Pages
{

    public class IndexModel : PageModel
    {

        private readonly IHomeServiceCategoryApplicationService _homeServiceCategoryApplicationService;
        public IndexModel(IHomeServiceCategoryApplicationService homeServiceCategoryApplicationService)
        {
            _homeServiceCategoryApplicationService = homeServiceCategoryApplicationService;
        }

        public List<HomeServiceCategoryDto> homeServiceCategories;


        public async Task OnGet(CancellationToken cancellationToken)
        {
           
            homeServiceCategories = await _homeServiceCategoryApplicationService.GetAll(cancellationToken);
        }
    }
}
