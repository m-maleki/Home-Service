using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Dtos;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.UI.Areas.Admin.Pages
{
    public class ExpertCommentModel : PageModel
    {
        private readonly ICommentApplicationService _commentApplicationService;
        public List<CommentViewModel> comments;
        private readonly IMapper _mapper;

        public ExpertCommentModel(ICommentApplicationService commentApplicationService,
            IMapper mapper)
        {
            _commentApplicationService = commentApplicationService;
            _mapper = mapper;
        }

        public async Task OnGet(Guid ExpertId)
        {
            var result = await _commentApplicationService.GetBy(ExpertId);
            comments =  _mapper.Map(result, comments);
            
        }
    }
}
