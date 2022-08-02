using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

        public async Task<int> Count(CancellationToken cancellationToken)
        {
            return await _customerRepository.Count(cancellationToken);
        }

        public Task Create(CustomerDto entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task EnsureDoesNotExist(Guid Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task EnsureDoesNotExist(string PhoneNumber, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task EnsureExists(Guid Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task EnsureExists(string PhoneNumber, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

     

        public Task<CustomerDto> Get(Guid Id, CancellationToken cancellationToken)
           => _customerRepository.GetBy(Id, cancellationToken);

        public Task<List<CustomerDto>> Get(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        public async Task<CustomerDto> Get(string email, CancellationToken cancellationToken)
        {
            var user = await _userManager.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Email == email);
            return await _customerRepository.GetBy(user!.Id, cancellationToken);
        }

        public async Task<List<OrderDto>> GetAllBy(Guid customerId, CancellationToken cancellationToken)
        {
           return await _customerRepository.GetAllBy(customerId, cancellationToken);
        }

        public async Task<Guid> GetCustomerId(Guid CustomerIdentityId, CancellationToken cancellationToken)
          => await _customerRepository.GetCustomerId(CustomerIdentityId, cancellationToken);

        public async Task Update(CustomerDto entity, CancellationToken cancellationToken)
        {
           await _customerRepository.Update(entity, cancellationToken);
        }

        public async Task<string> UploadImageProfile(IFormFile FormFile, CancellationToken cancellationToken)
        {
            string filePath;
            string fileName;
            if (FormFile != null)
            {
                fileName = Guid.NewGuid().ToString() +
                ContentDispositionHeaderValue.Parse(FormFile.ContentDisposition).FileName.Trim('"');
                filePath = Path.Combine("wwwroot/Images/Profiles", fileName);
                try
                {
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await FormFile.CopyToAsync(stream);
                    }
                }
                catch
                {
                    throw new Exception("Upload files operation failed");
                }
                return fileName;
            }
            else
                fileName = "";
            return fileName;
        }
    }
}
