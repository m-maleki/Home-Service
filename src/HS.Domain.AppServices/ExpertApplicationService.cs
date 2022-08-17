
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

        public async Task<int> Count(CancellationToken cancellationToken)
        {
            return await _expertService.Count(cancellationToken);
        }

        public Task Delete(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<ExpertDto> Get(CancellationToken cancellationToken)
        {
            var expertId= await _expertService.GetExpertId(_userApplicationService.GetUserId(cancellationToken), cancellationToken);
            var result =  await _expertService.Get(expertId, cancellationToken);
            result.Cities = await _cityService.Get(cancellationToken);
            result.SelectHomeServices = await _homeServiceService.Get(cancellationToken);
            result.HomeServicesUser = result.HomeServices;
            return result;
        }

        public async Task<ExpertDto> Get(string email, CancellationToken cancellationToken)
           => await _expertService.Get(email, cancellationToken);

        public async Task<List<ExpertDto>> GetAll(CancellationToken cancellationToken)
            => await _expertService.Get(cancellationToken);

        public async Task<List<OrderDto>> GetAllBy(Guid expertId, CancellationToken cancellationToken)
           => await _expertService.GetAllBy(expertId, cancellationToken);

        public Task<Guid> GetExpertId(CancellationToken cancellationToken)
            => _expertService.GetExpertId(_userApplicationService.GetUserId(cancellationToken),cancellationToken);

        public  async Task Set(ExpertDto dto, CancellationToken cancellationToken)
        {
             await _expertService.EnsureDoesNotExist(dto.ApplicationUserId, cancellationToken);
             await _expertService.Create(dto, cancellationToken);
        }

        public async Task Update(ExpertDto dto, CancellationToken cancellationToken)
        {
            if(dto.ProfileImgFile !=null)
                dto.ProfileImgUrl = await _expertService.UploadImageProfile(dto.ProfileImgFile, cancellationToken);
            await _expertService.AssignHomeService(dto, cancellationToken);
            await _expertService.Update(dto, cancellationToken);
        }
    }
}
