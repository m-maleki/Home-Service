using Framework.Infrastructure;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        private readonly HSDbContext _Context;
        public OrderRepository(HSDbContext context) : base(context)
        {
            _Context = context;
        }
    }
}
