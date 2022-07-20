using AutoMapper;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.EndPoints.RazorPages.ShopUI.Model;

namespace HS.EndPoints.RazorPages.UI.Model
{
    public class AutoMappingUi : Profile
    {
        public AutoMappingUi()
        {
            CreateMap< ExpertDto, UserViewModel>().ReverseMap();
            CreateMap<CustomerDto, UserViewModel>().ReverseMap();
            CreateMap<UserViewModel, ExpertDto>().ReverseMap();
            CreateMap<HomeService, HomeServiceViewModel>().ReverseMap();
            CreateMap<Order, OrderViewModel>().ReverseMap();
            CreateMap<OrderDto, OrderViewModel>().ReverseMap();
            CreateMap<SuggestionViewModel, SuggestionDto>();
            CreateMap<SuggestionDto, SuggestionViewModel>();
            CreateMap<OrderDto, OrderViewModel>();
            CreateMap<OrderFileDto, OrderFileViewModel>();
        }
    }
}
