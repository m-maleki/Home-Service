using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.ApplicationService
{
    public interface ICustomerApplicationService
    {
        Task<List<CustomerDto>> GetAll();
        Task Set(CustomerDto dto);
        Task<CustomerDto> Get();
        Task<CustomerDto> Get(string email);
        Task Update(CustomerDto dto);
        Task Delete(Guid id);
        Task<Guid> GetCustomerId(Guid CustomerIdentityId);
        Task<List<OrderDto>> GetAllBy(Guid customerId);
        Task<int> Count();
    }
}
