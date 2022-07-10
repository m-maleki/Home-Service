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
        public async Task<Customer> Get(int Id)
         => await _customerRepository.Get(Id);
        public async Task<List<Customer>> Get()
         => await _customerRepository.Get();
        public async Task EnsureExists(int Id)
        {
            if (await _customerRepository.Exists(x => x.Id == Id) == false)
                throw new Exception($"Customer with id : {Id} Not Exist !");
        }
        public async Task EnsureExists(string PhoneNumber)
        {
            if (await _customerRepository.Exists(x => x.PhoneNumber == PhoneNumber) == false)
                throw new Exception($"Customer with phonenumber : {PhoneNumber} Not Exist !");
        }
        public async Task EnsureDoesNotExist(int Id)
        {
            if (await _customerRepository.Exists(x => x.Id == Id) == true)
                throw new Exception($"there is already a Customer with id = {Id}");
        }
        public async Task EnsureDoesNotExist(string PhoneNumber)
        {
            if (await _customerRepository.Exists(x => x.PhoneNumber == PhoneNumber) == true)
                throw new Exception($"there is already a Customer with PhoneNumber = {PhoneNumber}");
        }
    }
}