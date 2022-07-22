using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Infrastructures.Database.Repos.Ef.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.ShopUI.Pages
{

    public class IndexModel : PageModel
    {
        private readonly IHomeServiceCategoryRepository _homeServiceCategory;

        public List<HomeServiceCategoryDto> homeServiceCategories;
        public IndexModel(IHomeServiceCategoryRepository homeServiceCategory)
        {
            _homeServiceCategory = homeServiceCategory;
        }

        public async Task OnGet()
        {
            homeServiceCategories = await _homeServiceCategory.GetAll();
        }
    }
}
