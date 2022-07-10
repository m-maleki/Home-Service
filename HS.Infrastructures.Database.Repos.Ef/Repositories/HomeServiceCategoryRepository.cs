using Framework.Infrastructure;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class HomeServiceCategoryRepository : RepositoryBase<HomeServiceCategory>, IHomeServiceCategoryRepository
    {
        private readonly HSDbContext _Context;

        public HomeServiceCategoryRepository(HSDbContext context) : base(context)
        {
            _Context=context;
        }
    }
}
