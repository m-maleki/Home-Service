using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.Service
{
    public interface ISpecialtyService
    {
        Task<Specialty> Get(int Id);
        Task<List<Specialty>> Get();
        Task Create(Specialty entity);
        Task<bool> Exists(int Id);
        Task<bool> Exists(string Name);
        Task Update(Specialty entity);
    }
}
