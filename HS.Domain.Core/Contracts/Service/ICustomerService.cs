using HS.Domain.Core.Entities;
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
        Task<Customer> Get(int Id);
        Task<List<Customer>> Get();
        Task Create(Customer entity);
        Task Update(Customer entity);
        Task EnsureExists(int Id);
        Task EnsureExists(string PhoneNumber);
        Task EnsureDoesNotExist(int Id);
        Task EnsureDoesNotExist(string PhoneNumber);

    }
}
