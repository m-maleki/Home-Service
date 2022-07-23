using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface ICustomerRepository 
    {
        Task<CustomerDto> GetBy(Guid id);
        Task<CustomerDto> GetBy(string mobileNumber);
        Task<List<CustomerDto>> GetAll();
        Task Create(CustomerDto entity);
        Task Update(CustomerDto entity);
        Task<Guid> GetCustomerId(Guid CustomerIdentityId);
        Task<List<OrderDto>> GetAllBy(Guid customerId);
    }
}
