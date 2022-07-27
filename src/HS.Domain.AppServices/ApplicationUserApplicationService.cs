using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Dtos.ApplicationUsers;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.ApplicationServices
{
    public class ApplicationUserApplicationService : IApplicationUserApplicationService
    {
        private readonly IApplicationUserService _applicationUserService;
        private readonly ICustomerService _customerService;
        private readonly IExpertService _expertService;
        private readonly IMapper _mapper;

        public ApplicationUserApplicationService(IApplicationUserService applicationUserService,
            IExpertService expertService,
            IMapper mapper,
            ICustomerService customerService)
        {
            _applicationUserService = applicationUserService;
            _expertService = expertService;
            _mapper = mapper;
            _customerService = customerService;
        }

        public async Task<IdentityResult> Create(ApplicationUserDto command)
            =>await _applicationUserService.Create(command);

        public Task<List<ApplicationUserDto>> GetAll()
        => _applicationUserService.GetAll();

        public Guid GetUserId()
        {
            return _applicationUserService.GetUserId();
        }

        public Task<SignInResult> Login(ApplicationUserDto command)
        => _applicationUserService.Login(command);

        public async Task Update(UserDto dto)
        {
            if(_applicationUserService.IsInRole("Expert"))
            {
                _mapper.Map(dto, new ExpertDto());
                if (dto.ProfileImgFile != null)
                    dto.ProfileImgUrl = await _expertService.UploadImageProfile(dto.ProfileImgFile);
                await _expertService.AssignHomeService(_mapper.Map(dto, new ExpertDto()));
                await _expertService.Update(_mapper.Map(dto, new ExpertDto()));
            }
            if (_applicationUserService.IsInRole("Customer"))
            {
                _mapper.Map(dto, new CustomerDto());
                if (dto.ProfileImgFile != null)
                    dto.ProfileImgUrl = await _customerService.UploadImageProfile(dto.ProfileImgFile);
                await _customerService.Update(_mapper.Map(dto, new CustomerDto()));

            }
        }
    }
}
