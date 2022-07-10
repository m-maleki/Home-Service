using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IHomeServiceCategoryService
    {
        Task<HomeServiceCategory> Get(int Id);
        Task<List<HomeServiceCategory>> Get();
        Task Create(HomeServiceCategory entity);
        Task<bool> Exists(int Id);
        Task<bool> Exists(string Name);
        Task Update(HomeServiceCategory entity);
    }
}
