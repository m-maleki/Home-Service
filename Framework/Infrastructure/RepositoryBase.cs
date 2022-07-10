using HS.Infrastructures.Database.SqlServer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Infrastructure
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly HSDbContext _context;

        public RepositoryBase(HSDbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Add(entity);
        }

        public bool Exists(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Any(expression);
        }

        public T Get(int Id)
        {
            return _context.Find<T>(Id);
        }

        public List<T> Get()
        {
            return _context.Set<T>().ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            SaveChanges();
        }
    }
}
