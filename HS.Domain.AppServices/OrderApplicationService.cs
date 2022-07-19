using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.ApplicationServices
{
    public class OrderApplicationService : IOrderApplicationService
    {
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;

        public OrderApplicationService(IOrderService orderService,
            ICustomerService customerService)
        {
            _orderService = orderService;
            _customerService = customerService;
        }

        public async Task Create(OrderDto entity, List<IFormFile> FormFile)
        {
            entity.CustomerId= await _customerService.GetGuid(new Guid(entity.currentApplicationUserID));
            PersianCalendar pc = new PersianCalendar();
            TimeSpan time = new TimeSpan(int.Parse(entity.Clock.Substring(0,2)), int.Parse(entity.Clock.Substring(3, 2)),0);
            entity.DateOfExecution = new DateTime(entity.DateOfExecution.Year, entity.DateOfExecution.Month, entity.DateOfExecution.Day,  pc);
            entity.DateOfExecution =  entity.DateOfExecution.Add(time);
            var orderId = await _orderService.Create(entity);
            var files = await _orderService.UploadFiles(FormFile, orderId);
            await _orderService.SetOrderFiles(files, orderId);
        }

        public async Task<OrderDto> Get(int Id)
         => await  _orderService.Get(Id);

        public async Task<List<OrderDto>> Get()
         => await _orderService.Get();

        public async Task<List<OrderDto>> GetAllBy(Guid customerId)
        {
            var id = await _customerService.GetGuid(customerId);
             return await _orderService.GetAllBy(id);
        }

        public Task Update(OrderDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
