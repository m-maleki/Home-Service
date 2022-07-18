using AutoMapper;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;


namespace HS.Infrastructures.Database.Repos.Ef.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
         CreateMap<HomeServiceSubCategory, HomeServiceSubCategoryDto>();
            CreateMap<HomeServiceCategory, HomeServiceCategoryDto>();


            CreateMap<HomeServiceDto, HomeService>();
            //.ForMember(x => x.home, opt => opt.Ignore())
            //.ForMember(x => x.HomeServiceSubCategoryId, opt => opt.Ignore());

            CreateMap<HomeService, HomeServiceDto>();
         //.ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<Suggestion, SuggestionDto>();
         CreateMap<Customer, CustomerDto>().ReverseMap();
         CreateMap<Comment, CommentDto>();
         CreateMap<Expert, ExpertDto>();
            CreateMap<ExpertDto, Expert>()
            .ForMember(x => x.HomeServices, opt => opt.Ignore());
        // .ReverseMap();
            CreateMap<Image, ImageDto>();
         CreateMap<Order, OrderDto>();

        }
    }
}
