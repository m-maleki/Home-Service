
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;

namespace HS.Domain.ApplicationServices
{
    public class ExpertApplicationService : IExpertApplicationService
    {
        private readonly IExpertService _expertService;
        private readonly IApplicationUserApplicationService _userApplicationService;
        private readonly ICityService _cityService;
        private readonly IHomeServiceService _homeServiceService;
        public ExpertApplicationService(IExpertService expertService,
            IApplicationUserApplicationService userApplicationService,
            ICityService cityService,
            IHomeServiceService homeServiceService)
        {
            _expertService = expertService;
            _userApplicationService = userApplicationService;
            _cityService = cityService;
            _homeServiceService = homeServiceService;
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ExpertDto> Get()
        {
            var expertId= await _expertService.GetExpertId(_userApplicationService.GetUserId());
            var result =  await _expertService.Get(expertId);
            result.Cities = await _cityService.Get();
            result.SelectHomeServices = await _homeServiceService.Get();
            result.HomeServicesUser = result.HomeServices;
            return result;
        }

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
