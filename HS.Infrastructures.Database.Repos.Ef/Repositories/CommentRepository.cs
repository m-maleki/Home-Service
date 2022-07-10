using Framework.Infrastructure;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        private readonly HSDbContext _Context;
        public CommentRepository(HSDbContext context) : base(context)
        {
            _Context = context;
        }
    }
}
