
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
        Task<OrderDto> Get(int Id);
        Task<OrderDto> GetBy(int orderId);
        Task<List<OrderDto>> Get();
        Task<List<OrderDto>> GetAll();
        Task Create(OrderDto entity, List<IFormFile> FormFile);
        Task Update(OrderDto entity);
        Task SetOrderStatusEnum(int orderId, OrderStatusEnum orderStatusEnum);
        Task<OrderStatusEnum> GetOrderStatusEnum(int orderId);
        Task SoftDelete(int orderId);
        Task HardDelete(int orderId);
        Task SoftRecover(int orderId);
    }
}
