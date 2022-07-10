using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.Service
{
    public interface ICommentService
    {
        Task<Comment> Get(int Id);
        Task<List<Comment>> Get();
        Task Create(Comment entity);
        Task<bool> Exists(int Id);
        Task Update(Comment entity);
    }
}
