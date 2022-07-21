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

        public async Task Active(int commentId)
        {
            await _commentService.Active(commentId);
        }

        public async Task Create(string comment,int orderId)
        {
            var expertId =await _suggestionService.GetAcceptSuggestionExpertId(orderId);
            await _commentService.Create(comment,expertId);
        }

        public async Task DeActive(int commentId)
        {
            await _commentService.DeActive(commentId);
        }

        public async Task<List<CommentDto>> GetAll()
        {
            return await _commentService.GetAll();
        }

        public Task<CommentDto> GetBy(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CommentDto>> GetBy(Guid expertId)
        {
            return await _commentService.GetBy(expertId);
        }

        public Task Update(CommentDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
