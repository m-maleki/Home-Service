using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IOrderRepository
    {
        Task<List<OrderDto>> GetAll();
        Task<OrderDto> GetBy(int id);
        Task<int> Create(OrderDto entity);
        Task Update(OrderDto entity);
        Task addOrderFiles(List<OrderFileDto> dto, int orderId);
    }
}
