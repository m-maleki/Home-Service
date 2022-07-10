using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
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
            await _commentRepository.Create(entity);
        }

        public async Task Update(Comment entity)
        {
            await _commentRepository.Update(entity);
        }

        public async Task<bool> Exists(int Id)
         => await _commentRepository.Exists(x => x.Id == Id);

        public async Task<Comment> Get(int Id)
         => await _commentRepository.Get(Id);

        public async Task<List<Comment>> Get()
         => await _commentRepository.Get();

    }
}