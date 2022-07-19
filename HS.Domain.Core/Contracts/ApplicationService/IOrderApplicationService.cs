
using HS.Domain.Core.Dtos;
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
        Task<List<OrderDto>> Get();
        Task<List<OrderDto>> GetAllBy(Guid Id, bool isExpert);
        Task Create(OrderDto entity, List<IFormFile> FormFile);
        Task Update(OrderDto entity);
    }
}
