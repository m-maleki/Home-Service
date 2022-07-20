using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Domain.Core.Enums;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IOrderRepository
    {
        Task<List<OrderDto>> GetAll();
        Task<OrderDto> GetBy(int id);
        Task<int> Create(OrderDto entity);
        Task Update(OrderDto entity);
        Task addOrderFiles(List<OrderFileDto> dto, int orderId);
        Task SetOrderStatusEnum(int orderId, OrderStatusEnum orderStatusEnum);
        Task<OrderStatusEnum> GetOrderStatusEnum(int orderId);
    }
}
