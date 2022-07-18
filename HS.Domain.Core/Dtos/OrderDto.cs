using HS.Domain.Core.Entities;
using HS.Domain.Core.Enums;

namespace HS.Domain.Core.Dtos
{
    public class OrderDto
    {
        #region Properties
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public int HomeServiceId { get; set; }
        public OrderStatusEnum Status { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public string? Description { get; set; }
        public DateTime DateOfExecution { get; set; }
        public string Clock { get; set; }
        public string currentApplicationUserID { get; set; }

        #endregion Properties

        #region Navigation properties
        public List<Image>? Images { get; set; }
        public List<Suggestion>? Suggestions { get; set; }
        public Customer Customer { get; set; }
        public HomeService? HomeService { get; set; }
        #endregion Navigation properties
    }
}
