using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IOrderService
    {
        Task<Order> Get(int Id);
        Task<List<Order>> Get();
        Task Create(Order entity);
        Task Update(Order entity);
        Task EnsureExists(int Id);
        Task EnsureDoesNotExist(int Id);
    }
}
