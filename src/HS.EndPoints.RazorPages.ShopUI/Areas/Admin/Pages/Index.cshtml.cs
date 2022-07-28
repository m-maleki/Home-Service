using HS.Domain.Core.Contracts.ApplicationService;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.ShopUI.Areas.Admin.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly IExpertApplicationService _expertApplicationService;
        private readonly ICustomerApplicationService _customerApplicationService;
        private readonly IOrderApplicationService _orderApplicationService;
        private readonly ISuggestionApplicationService _suggestionApplicationService;
        public DashboardViewModel dashboardViewModel { get; set; } = new DashboardViewModel();

        public IndexModel(IExpertApplicationService expertApplicationService,
            ICustomerApplicationService customerApplicationService,
            IOrderApplicationService orderApplicationService,
            ISuggestionApplicationService suggestionApplicationService)
        {
            _expertApplicationService = expertApplicationService;
            _customerApplicationService = customerApplicationService;
            _orderApplicationService = orderApplicationService;
            _suggestionApplicationService = suggestionApplicationService;
        }

        public async Task OnGet()
        {
            dashboardViewModel.CountExpert = await _expertApplicationService.Count();
            dashboardViewModel.CountCustomer = await _customerApplicationService.Count();
            dashboardViewModel.CountOrder = await _orderApplicationService.Count();
            dashboardViewModel.CountSuggestion = await _suggestionApplicationService.Count();
        }
    }
}
