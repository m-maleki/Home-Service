using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface ICustomerRepository 
    {
        Task<CustomerDto> GetBy(Guid id, CancellationToken cancellationToken);
        Task<CustomerDto> GetBy(string mobileNumber, CancellationToken cancellationToken);
        Task<List<CustomerDto>> GetAll(CancellationToken cancellationToken);
        Task Create(CustomerDto entity, CancellationToken cancellationToken);
        Task Update(CustomerDto entity, CancellationToken cancellationToken);
        Task<Guid> GetCustomerId(Guid CustomerIdentityId, CancellationToken cancellationToken);
        Task<List<OrderDto>> GetAllBy(Guid customerId, CancellationToken cancellationToken);
        Task<int> Count(CancellationToken cancellationToken);
    }
}
