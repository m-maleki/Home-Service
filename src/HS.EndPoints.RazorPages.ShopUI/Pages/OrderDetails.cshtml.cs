using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.UI.Pages
{
    public class OrderDetailsModel : PageModel
    {
        private readonly ISuggestionApplicationService _suggestionApplicationService;
        private readonly IOrderFileApplicationService _orderFileApplicationService;
        private readonly ICommentApplicationService _commentApplicationService;
        private readonly IExpertApplicationService _expertApplicationService;
        private readonly IOrderApplicationService _orderApplicationService;
        private readonly IMapper _mapper;
        public ICollection<SuggestionViewModel> suggestions = new List<SuggestionViewModel>();
        public ICollection<OrderFileViewModel> orderFiles = new List<OrderFileViewModel>();
        public string currentUserID { get; set; } = string.Empty;
        public OrderViewModel Order = new OrderViewModel();

        public Guid UserId;

        public OrderDetailsModel(ISuggestionApplicationService suggestionApplicationService,
            IOrderFileApplicationService orderFileApplicationService,
            ICommentApplicationService commentApplicationService,
            IExpertApplicationService expertApplicationService,
            IOrderApplicationService orderApplicationService,
            IMapper mapper)
        {
            _suggestionApplicationService = suggestionApplicationService;
            _orderFileApplicationService = orderFileApplicationService;
            _commentApplicationService = commentApplicationService;
            _expertApplicationService = expertApplicationService;
            _orderApplicationService = orderApplicationService;
            _mapper = mapper;
        }

        public async Task OnGet(int OrderId)
        {
            
            _mapper.Map(await _orderApplicationService.GetBy(OrderId), Order);
            _mapper.Map(await _suggestionApplicationService.GetAll(OrderId), suggestions);
            _mapper.Map(await _orderFileApplicationService.GetAll(OrderId), orderFiles);
            if (User.IsInRole("Expert"))
                UserId = await _expertApplicationService.GetExpertId();
        }
    }
}
