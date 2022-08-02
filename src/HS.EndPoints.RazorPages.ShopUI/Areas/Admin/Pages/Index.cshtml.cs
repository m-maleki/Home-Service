using AutoMapper;
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

        private readonly IMapper _mapper;

        public DashboardViewModel dashboardViewModel { get; set; } = new DashboardViewModel();
        public ICollection<OrderViewModel>? Orders = new List<OrderViewModel>();
        public ICollection<SuggestionViewModel> suggestions = new List<SuggestionViewModel>();
        public IndexModel(IExpertApplicationService expertApplicationService,
            ICustomerApplicationService customerApplicationService,
            IOrderApplicationService orderApplicationService,
            ISuggestionApplicationService suggestionApplicationService,
            IMapper mapper)
        {
            _expertApplicationService = expertApplicationService;
            _customerApplicationService = customerApplicationService;
            _orderApplicationService = orderApplicationService;
            _suggestionApplicationService = suggestionApplicationService;
            _mapper = mapper;
        }

        public async Task OnGet(CancellationToken cancellationToken)
        {
            dashboardViewModel.CountExpert = await _expertApplicationService.Count(cancellationToken);
            dashboardViewModel.CountCustomer = await _customerApplicationService.Count(cancellationToken);
            dashboardViewModel.CountOrder = await _orderApplicationService.Count(cancellationToken);
            dashboardViewModel.CountSuggestion = await _suggestionApplicationService.Count(cancellationToken);
            Orders = _mapper.Map(await _orderApplicationService.GetAll(cancellationToken), Orders);
            suggestions = _mapper.Map(await _suggestionApplicationService.Get(cancellationToken),new List<SuggestionViewModel>());

        }
    }
}
