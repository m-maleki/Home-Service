using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using System.Linq.Expressions;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface ICommentRepository 
    {
        Task<CommentDto> Get(int Id);
        Task<List<CommentDto>> Get();
        Task Create(CommentDto entity);
        Task Update(CommentDto entity);
    }
}
