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
        Task<OrderDto> Get(int Id);
        Task<OrderDto> GetBy(int orderId);
        Task<List<OrderDto>> Get();
        Task<int> Create(OrderDto entity);
        Task Update(OrderDto entity);
        Task EnsureExists(int Id);
        Task EnsureDoesNotExist(int Id);
        Task SetOrderFiles(List<OrderFileDto> dto, int orderId);
        Task<List<OrderFileDto>> UploadFiles(List<IFormFile> FormFile, int orderId);
        Task SetOrderStatusEnum(int orderId, OrderStatusEnum orderStatusEnum);
        Task<OrderStatusEnum> GetOrderStatusEnum(int orderId);
        Task SoftDelete(int orderId);
        Task HardDelete(int orderId);
        Task SoftRecover(int orderId);

    }
}
