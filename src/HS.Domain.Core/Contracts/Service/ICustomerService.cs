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
        Task<CustomerDto> Get(Guid Id, CancellationToken cancellationToken);
        Task<List<CustomerDto>> Get(CancellationToken cancellationToken);
        Task<CustomerDto> Get(string email, CancellationToken cancellationToken);
        Task Create(CustomerDto entity, CancellationToken cancellationToken);
        Task Update(CustomerDto entity, CancellationToken cancellationToken);
        Task EnsureExists(Guid Id, CancellationToken cancellationToken);
        Task EnsureExists(string PhoneNumber, CancellationToken cancellationToken);
        Task EnsureDoesNotExist(Guid Id, CancellationToken cancellationToken);
        Task EnsureDoesNotExist(string PhoneNumber, CancellationToken cancellationToken);
        Task<string> UploadImageProfile(IFormFile FormFile, CancellationToken cancellationToken);
        Task<Guid> GetCustomerId(Guid CustomerIdentityId, CancellationToken cancellationToken);
        Task<List<OrderDto>> GetAllBy(Guid customerId, CancellationToken cancellationToken);
        Task<int> Count(CancellationToken cancellationToken);
    }
}
