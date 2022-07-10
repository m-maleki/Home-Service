using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Entities;


namespace HS.Domain.Services.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task Create(Customer entity)
        {
            await _customerRepository.Create(entity);
        }

        public async Task Update(Customer entity)
        {
            await _customerRepository.Update(entity);
        }

        public async Task<bool> Exists(int Id)
         => await _customerRepository.Exists(x => x.Id == Id);

        public async Task<Customer> Get(int Id)
         => await _customerRepository.Get(Id);

        public async Task<List<Customer>> Get()
         => await _customerRepository.Get();

        public async Task<bool> Exists(string Firstname, string LastName)
         => await _customerRepository.Exists(x => x.FirstName == Firstname && x.LastName == LastName);

        public async Task Exists(string PhoneNumber)
         => await _customerRepository.Exists(x => x.PhoneNumber == PhoneNumber);

    }
}
