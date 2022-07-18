using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository,
            IMapper mapper,
            UserManager<ApplicationUser> userManager)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            _userManager = userManager;
        }

        public Task Create(CustomerDto entity)
        {
            throw new NotImplementedException();
        }

        public Task EnsureDoesNotExist(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task EnsureDoesNotExist(string PhoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task EnsureExists(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task EnsureExists(string PhoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDto> Get(Guid Id)
           => _customerRepository.GetBy(Id);

        public Task<List<CustomerDto>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<CustomerDto> Get(string email)
        {
            var user = await _userManager.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Email == email);
            return await _customerRepository.GetBy(user!.Id);
        }

        public Task Update(CustomerDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
