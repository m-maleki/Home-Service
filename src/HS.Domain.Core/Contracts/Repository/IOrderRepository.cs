using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Domain.Core.Enums;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IOrderRepository
    {
        Task<List<OrderDto>> GetAll(CancellationToken cancellationToken);
        Task<OrderDto> GetBy(int orderId, CancellationToken cancellationToken);
        Task<int> Create(OrderDto entity, CancellationToken cancellationToken);
        Task Update(OrderDto entity, CancellationToken cancellationToken);
        Task addOrderFiles(List<OrderFileDto> dto, int orderId, CancellationToken cancellationToken);
        Task SetOrderStatusEnum(int orderId, OrderStatusEnum orderStatusEnum, CancellationToken cancellationToken);
        Task<OrderStatusEnum> GetOrderStatusEnum(int orderId, CancellationToken cancellationToken);

        Task SoftDelete(int orderId, CancellationToken cancellationToken);
        Task HardDelete(int orderId, CancellationToken cancellationToken);
        Task SoftRecover(int orderId, CancellationToken cancellationToken);
        Task<int> Count(CancellationToken cancellationToken);

    }
}
