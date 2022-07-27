
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;

namespace HS.Domain.ApplicationServices
{
    public class ExpertApplicationService : IExpertApplicationService
    {
        private readonly IExpertService _expertService;
        private readonly IApplicationUserApplicationService _userApplicationService;
        public ExpertApplicationService(IExpertService expertService,
            IApplicationUserApplicationService userApplicationService)
        {
            _expertService = expertService;
            _userApplicationService = userApplicationService;
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ExpertDto> Get()
        {
            var expertId= await _expertService.GetExpertId(_userApplicationService.GetUserId());
            return await _expertService.Get(expertId);
        }
            //=>_expertService.Get(id);

        public async Task<ExpertDto> Get(string email)
           => await _expertService.Get(email);

        public async Task<List<ExpertDto>> GetAll()
            => await _expertService.Get();

        public async Task<List<OrderDto>> GetAllBy(Guid expertId)
        {
           return await _expertService.GetAllBy(expertId);
        }

        public Task<Guid> GetExpertId()
            => _expertService.GetExpertId(_userApplicationService.GetUserId());

        public  async Task Set(ExpertDto dto)
        {
             await _expertService.EnsureDoesNotExist(dto.ApplicationUserId);
             await _expertService.Create(dto);
        }

        public async Task Update(ExpertDto dto)
        {
            if(dto.ProfileImgFile !=null)
                dto.ProfileImgUrl = await _expertService.UploadImageProfile(dto.ProfileImgFile);
            await _expertService.AssignHomeService(dto);
            await _expertService.Update(dto);
        }
    }
}
