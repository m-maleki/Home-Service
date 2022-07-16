using AutoMapper;
using HS.Domain.Core.Dtos;
using HS.EndPoints.RazorPages.ShopUI.Model;

namespace HS.EndPoints.RazorPages.UI.Model
{
    public class AutoMappingUi : Profile
    {
        public AutoMappingUi()
        {
            CreateMap< ExpertDto, UserViewModel>();
        }
    }
}
