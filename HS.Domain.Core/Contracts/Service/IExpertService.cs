using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using Microsoft.AspNetCore.Http;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IExpertService
    {
        Task<ExpertDto> Get(Guid id);
        Task<ExpertDto> Get(string email);
        Task<List<ExpertDto>> Get();
        Task Create(ExpertDto entity);
        Task Update(ExpertDto entity);
        Task EnsureExists(Guid id);
        Task EnsureDoesNotExist(Guid id);
        Task<string> UploadImageProfile(IFormFile FormFile);
        Task<ExpertDto> AssignHomeService(ExpertDto entity);
    }
}