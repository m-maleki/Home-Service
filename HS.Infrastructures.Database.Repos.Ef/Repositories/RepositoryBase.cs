using HS.Domain.Core.Contracts.Repository;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly HSDbContext _context;

        public RepositoryBase(HSDbContext context)
        {
            _context = context;
        }

        public async Task Create(T entity)
        {
            await _context.AddAsync(entity);
        }

        public async Task<bool> Exists(Expression<Func<T, bool>> expression)
            => await _context.Set<T>().AnyAsync(expression);

        public async Task<T> Get(int Id)
            => await _context.FindAsync<T>(Id);

        public async Task<List<T>> Get()
            => await _context.Set<T>().ToListAsync();

        public async Task SaveChanges()
            => await _context.SaveChangesAsync();

        public async Task Update(T entity)
        {
            _context.Update(entity);
            await SaveChanges();
        }


    }
}
