using System.Linq.Expressions;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> Get(int Id);
        Task<List<T>> Get();
        Task Create(T entity);
        Task<bool> Exists(Expression<Func<T, bool>> expression);
        Task Update(T entity);
        Task SaveChanges();
    }
}
