using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    public class OrderDetailsModel : PageModel
    {
        private readonly IOrderApplicationService _orderApplicationService;
        private readonly ISuggestionApplicationService _suggestionApplicationService;
        private readonly IOrderFileApplicationService _orderFileApplicationService;

        public List<SuggestionViewModel> suggestions = new();
        public List<OrderFileViewModel> orderFiles = new();
        public OrderViewModel Order;
        private readonly IMapper _mapper;

        public OrderDetailsModel(IOrderApplicationService orderApplicationService,
            IMapper mapper,
            ISuggestionApplicationService suggestionApplicationService,
            IOrderFileApplicationService orderFileApplicationService)
        {
            _orderApplicationService = orderApplicationService;
            _mapper = mapper;
            _suggestionApplicationService = suggestionApplicationService;
            _orderFileApplicationService = orderFileApplicationService;
        }

        public async Task OnGet(int OrderId)
        {
            var orderRecord = await _orderApplicationService.GetBy(OrderId);
            Order= _mapper.Map(orderRecord, Order);

            var suggestionRecords = await _suggestionApplicationService.GetAll(OrderId);
            _mapper.Map(suggestionRecords, suggestions);

            var orderFileRecords = await _orderFileApplicationService.GetAll(OrderId);
            _mapper.Map(orderFileRecords, orderFiles);
        }

        public async Task<IActionResult> OnPostDeleteImage(int imageId)
        {
             await _orderFileApplicationService.DeleteFile(imageId);
            return LocalRedirect("/Admin/Order/");
        }
    }
}
