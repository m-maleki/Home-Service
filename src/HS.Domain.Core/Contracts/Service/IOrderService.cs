using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Domain.Core.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IOrderService
    {
        Task<OrderDto> Get(int Id,CancellationToken cancellationToken);
        Task<OrderDto> GetBy(int orderId, CancellationToken cancellationToken);
        Task<List<OrderDto>> Get(CancellationToken cancellationToken);
        Task<int> Create(OrderDto entity, CancellationToken cancellationToken);
        Task Update(OrderDto entity, CancellationToken cancellationToken);
        Task EnsureExists(int Id, CancellationToken cancellationToken);
        Task EnsureDoesNotExist(int Id, CancellationToken cancellationToken);
        Task SetOrderFiles(List<OrderFileDto> dto, int orderId, CancellationToken cancellationToken);
        Task<List<OrderFileDto>> UploadFiles(List<IFormFile> FormFile, int orderId);
        Task SetOrderStatusEnum(int orderId, OrderStatusEnum orderStatusEnum, CancellationToken cancellationToken);
        Task<OrderStatusEnum> GetOrderStatusEnum(int orderId, CancellationToken cancellationToken);
        Task SoftDelete(int orderId, CancellationToken cancellationToken);
        Task HardDelete(int orderId, CancellationToken cancellationToken);
        Task SoftRecover(int orderId, CancellationToken cancellationToken);
        Task<int> Count(CancellationToken cancellationToken);

    }
}
