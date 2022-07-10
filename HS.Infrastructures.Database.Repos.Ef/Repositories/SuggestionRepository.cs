using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class SuggestionRepository : RepositoryBase<Suggestion>, ISuggestionRepository
    {
        private readonly HSDbContext _Context;
        public SuggestionRepository(HSDbContext context) : base(context)
        {
            _Context = context;
        }
    }
}
