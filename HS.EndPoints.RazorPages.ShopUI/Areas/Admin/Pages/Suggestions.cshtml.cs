using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Dtos;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    public class SuggestionsModel : PageModel
    {
        private readonly ISuggestionApplicationService _suggestionApplicationService;
        public List<SuggestionViewModel> suggestions = new();
        private readonly IMapper _mapper;

        public SuggestionsModel(ISuggestionApplicationService suggestionApplicationService,
            IMapper mapper)
        {
            _suggestionApplicationService = suggestionApplicationService;
            _mapper = mapper;
        }

        public async Task OnGet(int orderId)
        {
            var records  =  await _suggestionApplicationService.GetAll(orderId);
            _mapper.Map(records,suggestions);


        }

        public async Task<IActionResult> OnPostAccept(int SuggId , int OrderId)
        {
           await _suggestionApplicationService.Accept(SuggId, OrderId);
           return LocalRedirect("/Admin/Order/");
        }

        public void OnPost(int id)
        {

        }
    }
}
