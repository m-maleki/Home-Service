using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IHomeServiceService
    {
        Task<HomeService> Get(int Id);
        Task<List<HomeService>> Get();
        Task Create(HomeService entity);
        Task<bool> Exists(int Id);
        Task<bool> Exists(string Name);
        Task Update(HomeService entity);
    }
}
