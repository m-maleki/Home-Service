using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<int> Count()
        {
            return await _orderRepository.Count();
        }

        public async Task<int> Create(OrderDto entity)
        {
          return await _orderRepository.Create(entity);
        }

        public Task EnsureDoesNotExist(int Id)
        {
            throw new NotImplementedException();
        }

        public Task EnsureExists(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<OrderDto> Get(int Id)
          => await _orderRepository.GetBy(Id);

        public async Task<List<OrderDto>> Get()
        {
            return await _orderRepository.GetAll();
        }

        public async Task<OrderDto> GetBy(int orderId)
        {
            return await _orderRepository.GetBy(orderId);
        }

        public async Task<OrderStatusEnum> GetOrderStatusEnum(int orderId)
        {
            return await _orderRepository.GetOrderStatusEnum(orderId);
        }

        public async Task HardDelete(int orderId)
        {
            await _orderRepository.HardDelete(orderId);
        }

        public async Task SetOrderFiles(List<OrderFileDto> dto, int orderId)
        {
           await _orderRepository.addOrderFiles(dto, orderId);
        }

        public async Task SetOrderStatusEnum(int orderId, OrderStatusEnum orderStatusEnum)
        {
            await _orderRepository.SetOrderStatusEnum(orderId, orderStatusEnum);
        }

        public async Task SoftDelete(int orderId)
        {
            await _orderRepository.SoftDelete(orderId);
        }

        public async Task SoftRecover(int orderId)
        {
            await _orderRepository.SoftRecover(orderId);
        }

        public Task Update(OrderDto entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderFileDto>> UploadFiles(List<IFormFile> FormFile, int orderId)
        {
            var files = new List<string>();
            foreach (var formFile in FormFile)
            {
                if (formFile.Length > 0)
                {
                    var filename = Path.Combine("wwwroot/Images/Profiles", Guid.NewGuid().ToString() +
                        ContentDispositionHeaderValue.Parse(formFile.ContentDisposition).FileName.Trim('"'));
                    files.Add(filename);
                    try
                    {
                        using (var stream = System.IO.File.Create(filename))
                        {
                            await formFile.CopyToAsync(stream);
                        }
                    }
                    catch
                    {
                        throw new Exception("Upload files operation failed");
                    }
                }
            }
            var OrderFiles = new List<OrderFileDto>();
            foreach (var file in files)
            {
                OrderFileDto orderfile = new OrderFileDto
                {
                    Name = file.Substring(8, file.Length-8),
                    OrderId = orderId

                };
                OrderFiles.Add(orderfile);
            }
            return OrderFiles;
        }

    }
}
