using HS.Domain.Core.Enums;

namespace HS.Domain.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CoutomerId { get; set; }
        public int HomeServiceId { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public OrderStatusEnum Status { get; set; }
        public List<string>? ImagesUrl { get; set; }
    }
}
