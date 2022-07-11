using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;

namespace HS.Domain.Services.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public async Task Create(Comment entity)
        {
          //  await _commentRepository.Create(entity);
        }
        public async Task Update(Comment entity)
        {
           // await _commentRepository.Update(entity);
        }
        public async Task<CommentDto> Get(int Id)
         => await _commentRepository.Get(Id);
        public async Task<List<CommentDto>> Get()
         => await _commentRepository.Get();
        public async Task EnsureDoesNotExist(int Id)
        {

        }
        public async Task EnsureExists(int Id)
        {

        }

        Task<Comment> ICommentService.Get(int Id)
        {
            throw new NotImplementedException();
        }

        Task<List<Comment>> ICommentService.Get()
        {
            throw new NotImplementedException();
        }
    }
}