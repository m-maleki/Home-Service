
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;

namespace HS.Domain.ApplicationServices
{
    public class ExpertApplicationService : IExpertApplicationService
    {
        private readonly IExpertService _expertService;

        public ExpertApplicationService(IExpertService expertService)
        {
            _expertService = expertService;
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ExpertDto> Get(Guid id)
            =>_expertService.Get(id);

        public Task<ExpertDto> Get(string email)
           => _expertService.Get(email);

        public async Task<List<ExpertDto>> GetAll()
            => await _expertService.Get();

        public  async Task Set(ExpertDto dto)
        {
             await _expertService.EnsureDoesNotExist(dto.ApplicationUserId);
             await _expertService.Create(dto);
        }

        public async Task Update(ExpertDto dto)
        {
           await _expertService.Update(dto);
        }
    }
}
