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

        public async Task Create(ExpertDto entity)
        {
            await _expertRepository.Create(entity);
        }

        public async Task EnsureDoesNotExist(Guid id)
        {
            if (await _expertRepository.GetBy(id) != null)
                throw new Exception($"Expert Id : {id} Exists!");
        }

        public async Task EnsureExists(Guid id)
        {
            if (await _expertRepository.GetBy(id) == null)
                throw new Exception($"Expert Id : {id} Doesn't Exists!");
        }

        public async Task<ExpertDto> Get(Guid id)
            => await _expertRepository.GetBy(id);

        public async Task<List<ExpertDto>> Get()
            => await _expertRepository.GetAll();

        public async Task Update(ExpertDto entity)
        {
            await _expertRepository.Update(entity);
        }

        public async Task<ExpertDto> Get(string email)
        {
            var user = await _userManager.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Email == email);
            return await _expertRepository.GetBy(user!.Id);
        }

        public async Task<string> UploadImageProfile(IFormFile FormFile)
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

        public async Task<ExpertDto> AssignHomeService(ExpertDto entity)
        {
            foreach (var homeServiceId in entity.HomeServicesIds)
            {
                var record = await _homeServiceRepository.GetBy(homeServiceId);
                var homeService = new HomeService();

                _mapper.Map(record, homeService);
                entity.HomeServices.Add(homeService);
            }
            return entity;
        }

        public Task<Guid> GetExpertId(Guid expertIdentityId)
          =>_expertRepository.GetExpertId(expertIdentityId);

        public async Task<List<OrderDto>> GetAllBy(Guid expertId)
        {
      

            List<Order> result = new List<Order>();

            //var orders = await _context.Orders
            //    .Include(x => x.Customer)
            //    .Include(x => x.HomeService)
            //    .AsNoTracking()
            //    .ToListAsync();
            var orders =await _orderRepository.GetAll();


            //var expertHomeService = await _context.Experts
            //    .Include(x => x.HomeServices)
            //    .Where(x => x.Id == expertId)
            //    .AsNoTracking()
            //    .FirstAsync();
            var expertHomeService =await _expertRepository.GetBy(expertId);


            //foreach (var expertService in expertHomeService.HomeServices)
            //{
            //    foreach (var order in orders)
            //    {
            //        if (expertService.Name == order.HomeService.Name)
            //            result.Add(order);
            //    }
            //}

            return await _expertRepository.GetAllBy(expertId);
            //return _mapper.Map<List<OrderDto>>(result);

        }
    }
}
