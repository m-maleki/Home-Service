using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.ApplicationServices
{
    public class CommentApplicationService : ICommentApplicationService
    {
        private readonly ICommentService _commentService;
        private readonly ISuggestionService _suggestionService;

        public CommentApplicationService(ICommentService commentService,
            ISuggestionService suggestionService)
        {
            _commentService = commentService;
            _suggestionService = suggestionService;
        }

        public async Task Create(string comment,int orderId)
        {
            var expertId =await _suggestionService.GetAcceptSuggestionExpertId(orderId);
            await _commentService.Create(comment,expertId);
        }

        public Task<List<CommentDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CommentDto> GetBy(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(CommentDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
