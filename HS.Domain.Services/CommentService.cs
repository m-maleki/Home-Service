using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task Create(string comment, Guid expertId)
        {
            await _commentRepository.Create(comment, expertId);
        }

        public Task EnsureDoesNotExist(int Id)
        {
            throw new NotImplementedException();
        }

        public Task EnsureExists(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<CommentDto> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CommentDto>> Get()
        {
            throw new NotImplementedException();
        }

        public Task Update(CommentDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
