using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Dtos
{
    public class HomeServiceCategoryDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<HomeService>? HomeServices { get; set; }
    }
}
