using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        T Get(int Id);
        List<T> Get();
        void Create(T entity);
        bool Exists(Expression<Func<T, bool>> expression);
        void Update(T entity);
        void SaveChanges();
    }
}
