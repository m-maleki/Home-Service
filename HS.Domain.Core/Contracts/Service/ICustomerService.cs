using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.Service
{
    public interface ICustomerService
    {
        Task<CustomerDto> Get(Guid Id);
        Task<List<CustomerDto>> Get();
        Task<CustomerDto> Get(string email);
        Task Create(CustomerDto entity);
        Task Update(CustomerDto entity);
        Task EnsureExists(Guid Id);
        Task EnsureExists(string PhoneNumber);
        Task EnsureDoesNotExist(Guid Id);
        Task EnsureDoesNotExist(string PhoneNumber);
        Task<string> UploadImageProfile(IFormFile FormFile);
        Task<Guid> GetGuid(Guid customerId);
    }
}
