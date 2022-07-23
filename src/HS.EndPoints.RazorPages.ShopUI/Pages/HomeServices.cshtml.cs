using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.UI.Pages
{
    public class HomeServicesModel : PageModel
    {
        private readonly IHomeServiceApplicationService _homeServiceApplicationService;
        private readonly IMapper _mapper;

        public List<HomeServiceViewModel> homeServices;

        public HomeServicesModel(IHomeServiceApplicationService homeServiceApplicationService,
            IMapper mapper)
        {
            _homeServiceApplicationService = homeServiceApplicationService;
            _mapper = mapper;
        }

        public async Task OnGet(int id)
        {
            homeServices = _mapper.Map(await _homeServiceApplicationService.GetAll(id), new List<HomeServiceViewModel>());
        }
    }
}
