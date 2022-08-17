using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace HS.Domain.Services
{
    public class ExpertService : IExpertService
    {
        private readonly IExpertRepository _expertRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHomeServiceRepository _homeServiceRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;


        public ExpertService(IExpertRepository expertRepository,
            UserManager<ApplicationUser> userManager,
            IHomeServiceRepository homeServiceRepository,
            IMapper mapper,
            IOrderRepository orderRepository)
        {
            _expertRepository = expertRepository;
            _userManager = userManager;
            _homeServiceRepository = homeServiceRepository;
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        public async Task Create(ExpertDto entity, CancellationToken cancellationToken)
        {
            await _expertRepository.Create(entity, cancellationToken);
        }

        public async Task EnsureDoesNotExist(Guid id, CancellationToken cancellationToken)
        {
            if (await _expertRepository.GetBy(id, cancellationToken) != null)
                throw new Exception($"Expert Id : {id} Exists!");
        }

        public async Task EnsureExists(Guid id, CancellationToken cancellationToken)
        {
            if (await _expertRepository.GetBy(id, cancellationToken) == null)
                throw new Exception($"Expert Id : {id} Doesn't Exists!");
        }

        public async Task<ExpertDto> Get(Guid id, CancellationToken cancellationToken)
            => await _expertRepository.GetBy(id, cancellationToken);

        public async Task<List<ExpertDto>> Get(CancellationToken cancellationToken)
            => await _expertRepository.GetAll(cancellationToken);

        public async Task Update(ExpertDto entity, CancellationToken cancellationToken)
        {
            await _expertRepository.Update(entity, cancellationToken);
        }

        public async Task<ExpertDto> Get(string email, CancellationToken cancellationToken)
        {
            var user = await _userManager.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Email == email);
            return await _expertRepository.GetBy(user!.Id, cancellationToken);
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

        public async Task<ExpertDto> AssignHomeService(ExpertDto entity, CancellationToken cancellationToken)
        {
            foreach (var homeServiceId in entity.HomeServicesIds)
            {
                var record = await _homeServiceRepository.GetBy(homeServiceId, cancellationToken);
                var homeService = new HomeService();

                _mapper.Map(record, homeService);
                entity.HomeServices.Add(homeService);
            }
            return entity;
        }

        public Task<Guid> GetExpertId(Guid expertIdentityId, CancellationToken cancellationToken)
          =>_expertRepository.GetExpertId(expertIdentityId, cancellationToken);

        public async Task<List<OrderDto>> GetAllBy(Guid expertId, CancellationToken cancellationToken)
        {
            List<Order> result = new();
            var expertHomeService = await _expertRepository.GetBy(expertId, cancellationToken);
            var orders = _mapper.Map<List<Order>>(await _orderRepository.GetAll(cancellationToken));
           
            foreach (var expertService in expertHomeService.HomeServices)
                foreach (var order in orders)
                {
                    if (expertService.Name == order.HomeService.Name)
                        result.Add(order);
                }

            return _mapper.Map<List<OrderDto>>(result);
        }

        public async Task<int> Count(CancellationToken cancellationToken)
            => await _expertRepository.Count(cancellationToken);
    }
}
