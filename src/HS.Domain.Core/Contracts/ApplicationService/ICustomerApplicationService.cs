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
        Task<List<CustomerDto>> GetAll(CancellationToken cancellationToken);
        Task Set(CustomerDto dto, CancellationToken cancellationToken);
        Task<CustomerDto> Get(CancellationToken cancellationToken);
        Task<CustomerDto> Get(string email, CancellationToken cancellationToken);
        Task Update(CustomerDto dto, CancellationToken cancellationToken);
        Task Delete(Guid id, CancellationToken cancellationToken);
        Task<Guid> GetCustomerId(Guid CustomerIdentityId, CancellationToken cancellationToken);
        Task<List<OrderDto>> GetAllBy(Guid customerId, CancellationToken cancellationToken);
        Task<int> Count(CancellationToken cancellationToken);
    }
}
