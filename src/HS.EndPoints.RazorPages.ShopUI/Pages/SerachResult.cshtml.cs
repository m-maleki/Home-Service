using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.UI.Pages
{
    public class SerachResultModel : PageModel
    {
        private readonly IHomeServiceApplicationService _homeServiceApplicationService;

        public List<HomeServiceViewModel> homeServices;
        private readonly IMapper _mapper;
        public string keyworkSearch = string.Empty;

        public SerachResultModel(IHomeServiceApplicationService homeServiceApplicationService,
            IMapper mapper)
        {
            _homeServiceApplicationService = homeServiceApplicationService;
            _mapper = mapper;
        }

        public async Task<IActionResult> OnGet(string keyword,CancellationToken cancellationToken)
        {
            keyworkSearch = keyword;
            if (keyword is not null)
            {
                homeServices = _mapper.Map(await _homeServiceApplicationService.Search(keyword, cancellationToken),new List<HomeServiceViewModel>());
            }
            else
            {
                return default;
            }
            return default;
        }

    }
}
