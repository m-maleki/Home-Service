using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Dtos
{
    public class HomeServiceDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImgUrl { get; set; }
        public double Price { get; set; }
        public HomeServiceCategory? HomeServiceCategory { get; set; }
        public Order? Orders { get; set; }
    }
}
