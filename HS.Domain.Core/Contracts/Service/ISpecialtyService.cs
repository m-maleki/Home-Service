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
        Task Update(Specialty entity);
        Task EnsureExists(int Id);
        Task EnsureExists(string Name);
        Task EnsureDoesNotExist(int Id);
        Task EnsureDoesNotExist(string Name);
    }
}
