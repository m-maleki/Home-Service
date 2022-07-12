using HS.Domain.Core.Entities;
using HS.Domain.Core.Enums;


namespace HS.Domain.Core.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int HomeServiceId { get; set; }
        public OrderStatusEnum Status { get; set; }
        public List<Image>? Images { get; set; }
        public List<Suggestion>? Suggestions { get; set; }
        public HomeService? HomeService { get; set; }
    }
}
