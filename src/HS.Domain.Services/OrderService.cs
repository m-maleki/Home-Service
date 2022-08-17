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

        public async Task<int> Count(CancellationToken cancellationToken)
            => await _orderRepository.Count(cancellationToken);

        public async Task<int> Create(OrderDto entity, CancellationToken cancellationToken)
          => await _orderRepository.Create(entity, cancellationToken);

        public Task EnsureDoesNotExist(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public Task EnsureExists(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<OrderDto> Get(int Id, CancellationToken cancellationToken)
          => await _orderRepository.GetBy(Id, cancellationToken);

        public async Task<List<OrderDto>> Get(CancellationToken cancellationToken)
            => await _orderRepository.GetAll(cancellationToken);

        public async Task<OrderDto> GetBy(int orderId, CancellationToken cancellationToken)
            => await _orderRepository.GetBy(orderId, cancellationToken);

        public async Task<OrderStatusEnum> GetOrderStatusEnum(int orderId, CancellationToken cancellationToken)
            => await _orderRepository.GetOrderStatusEnum(orderId, cancellationToken);

        public async Task HardDelete(int orderId, CancellationToken cancellationToken)
        {
            await _orderRepository.HardDelete(orderId, cancellationToken);
        }

        public async Task SetOrderFiles(List<OrderFileDto> dto, int orderId, CancellationToken cancellationToken)
        {
           await _orderRepository.addOrderFiles(dto, orderId, cancellationToken);
        }

        public async Task SetOrderStatusEnum(int orderId, OrderStatusEnum orderStatusEnum,CancellationToken cancellationToken)
        {
            await _orderRepository.SetOrderStatusEnum(orderId, orderStatusEnum, cancellationToken);
        }

        public async Task SoftDelete(int orderId, CancellationToken cancellationToken)
        {
            await _orderRepository.SoftDelete(orderId, cancellationToken);
        }

        public async Task SoftRecover(int orderId, CancellationToken cancellationToken)
        {
            await _orderRepository.SoftRecover(orderId, cancellationToken);
        }

        public Task Update(OrderDto entity, CancellationToken cancellationToken)
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
                    var filename = Path.Combine("wwwroot/Images/Orders", Guid.NewGuid().ToString() +
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
