
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.ApplicationService
{
    public interface IOrderApplicationService
    {
        Task<OrderDto> Get(int Id, CancellationToken cancellationToken);
        Task<OrderDto> GetBy(int orderId, CancellationToken cancellationToken);
        Task<List<OrderDto>> Get(CancellationToken cancellationToken);
        Task<List<OrderDto>> GetAll(CancellationToken cancellationToken);
        Task Create(OrderDto entity, List<IFormFile> FormFile, CancellationToken cancellationToken);
        Task Update(OrderDto entity, CancellationToken cancellationToken);
        Task SetOrderStatusEnum(int orderId, OrderStatusEnum orderStatusEnum, CancellationToken cancellationToken);
        Task<OrderStatusEnum> GetOrderStatusEnum(int orderId, CancellationToken cancellationToken);
        Task SoftDelete(int orderId, CancellationToken cancellationToken);
        Task HardDelete(int orderId, CancellationToken cancellationToken);
        Task SoftRecover(int orderId, CancellationToken cancellationToken);
        Task<int> Count(CancellationToken cancellationToken);
    }
}
