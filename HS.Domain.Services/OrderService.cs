using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
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

        public async Task SetOrderFiles(List<OrderFileDto> dto, int orderId)
        {
           await _orderRepository.addOrderFiles(dto, orderId);
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
                    Name = file,
                    OrderId = orderId

                };
                OrderFiles.Add(orderfile);
            }
            return OrderFiles;
        }

    }
}
