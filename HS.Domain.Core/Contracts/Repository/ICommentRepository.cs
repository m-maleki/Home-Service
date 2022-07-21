using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using System.Linq.Expressions;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface ICommentRepository 
    {
        Task<CommentDto> GetBy(int id);
        Task<List<CommentDto>> GetAll();
        Task Create(string comment, Guid expertId);
        Task Update(CommentDto entity);
    }
}
