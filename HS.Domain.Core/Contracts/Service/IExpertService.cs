using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IExpertService
    {
        Task<Expert> Get(int Id);
        Task<List<Expert>> Get();
        Task Create(Expert entity);
        Task Update(Expert entity);
        Task EnsureExists(int Id);
        Task EnsureExists(string PhoneNumber);
        Task EnsureDoesNotExist(int Id);
        Task EnsureDoesNotExist(string PhoneNumber);
    }
}
