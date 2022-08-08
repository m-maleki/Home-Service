using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Dtos.ApplicationUsers;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace HS.Domain.ApplicationServices
{
    public class ApplicationUserApplicationService : IApplicationUserApplicationService
    {
        private readonly IApplicationUserService _applicationUserService;
        private readonly ICustomerService _customerService;
        private readonly IExpertService _expertService;
        private readonly IMapper _mapper;
        private readonly ICityService _cityService;
        private readonly IHomeServiceService _homeServiceService;
        private readonly ILogger<ApplicationUserApplicationService> _logger;

        public ApplicationUserApplicationService(
            IApplicationUserService applicationUserService,
            ICustomerService customerService,
            IExpertService expertService,
            IMapper mapper,
            ICityService cityService,
            IHomeServiceService homeServiceService,
            ILogger<ApplicationUserApplicationService> logger)
        {
            _applicationUserService = applicationUserService;
            _customerService = customerService;
            _expertService = expertService;
            _mapper = mapper;
            _cityService = cityService;
            _homeServiceService = homeServiceService;
            _logger = logger;
        }



        public async Task<bool> confirmEmail(string token)
        {
           return await _applicationUserService.confirmEmail(token);
        }

        public async Task<IdentityResult> Create(ApplicationUserDto command,CancellationToken cancellationToken)
        {
            var result =  await _applicationUserService.Create(command, cancellationToken);
            if(result.Succeeded)
            {
                var confirmKey = await _applicationUserService.SendEmailActivation(command.Email, cancellationToken);
                await _applicationUserService.SetConfirmKey(command.Email, confirmKey);
                return result;
            }
            else
            {
                return result;
            }
            
            return result;
        }
        public async Task ActiveEmailConfirm(string emailAddress)
        {
            await _applicationUserService.ActiveEmailConfirm(emailAddress);
        }

        public async Task DeActiveEmailConfirm(string emailAddress)
        {
            await _applicationUserService.DeActiveEmailConfirm(emailAddress);
        }

        public async Task<UserDto> Get(CancellationToken cancellationToken)
        {
            if (_applicationUserService.IsInRole("Expert"))
            {
                var expertId = await _expertService.GetExpertId(_applicationUserService.GetUserId(cancellationToken), cancellationToken);
                var result = await _expertService.Get(expertId, cancellationToken);
                result.Cities = await _cityService.Get(cancellationToken);
                result.SelectHomeServices = await _homeServiceService.Get(cancellationToken);
                result.HomeServicesUser = result.HomeServices;
                return _mapper.Map(result,new UserDto());
            }
            if (_applicationUserService.IsInRole("Customer"))
            {
                var customer = await _customerService.GetCustomerId(_applicationUserService.GetUserId(cancellationToken), cancellationToken);
                var result = await _customerService.Get(customer, cancellationToken);
                result.Cities = await _cityService.Get(cancellationToken);
                return _mapper.Map(result, new UserDto());
            }
            return default;
        }

        public Task<List<ApplicationUserDto>> GetAll(CancellationToken cancellationToken)
        => _applicationUserService.GetAll(cancellationToken);

        public Guid GetUserId(CancellationToken cancellationToken)
        {
            return _applicationUserService.GetUserId(cancellationToken);
        }

        public Task<SignInResult> Login(ApplicationUserDto command, CancellationToken cancellationToken)
        {
            _logger.LogInformation("User {emailAddress} login to website", command.Email);
            return _applicationUserService.Login(command, cancellationToken);

        }

        public async Task SetConfirmKey(string emailAddress, Guid confirmKey)
        {
            _logger.LogInformation("ConfirmKey {Key} set for user {emailAddress}", confirmKey, emailAddress);
            await _applicationUserService.SetConfirmKey(emailAddress, confirmKey);
        }

        public async Task Update(UserDto dto, CancellationToken cancellationToken)
        {
            if(_applicationUserService.IsInRole("Expert"))
            {
                _mapper.Map(dto, new ExpertDto());
                if (dto.ProfileImgFile != null)
                    dto.ProfileImgUrl = await _expertService.UploadImageProfile(dto.ProfileImgFile, cancellationToken);
                await _expertService.AssignHomeService(_mapper.Map(dto, new ExpertDto()), cancellationToken);
                await _expertService.Update(_mapper.Map(dto, new ExpertDto()), cancellationToken);
            }
            if (_applicationUserService.IsInRole("Customer"))
            {
                _mapper.Map(dto, new CustomerDto());
                if (dto.ProfileImgFile != null)
                    dto.ProfileImgUrl = await _customerService.UploadImageProfile(dto.ProfileImgFile, cancellationToken);
                await _customerService.Update(_mapper.Map(dto, new CustomerDto()), cancellationToken);
            }
        }

        public async Task<bool> EmailIsConfirmed(string emailAddress)
        {
            _logger.LogInformation("user {emailAddress} confirmed account", emailAddress);
            return await _applicationUserService.EmailIsConfirmed(emailAddress);

        }
    }
}
