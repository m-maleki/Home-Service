using HS.Domain.Core.Enums;

namespace HS.Domain.Core.Entities
{
    public class Order
    {
        #region Properties
        public int Id { get; set; }
        public Guid CustomerId { get; set; }
        public int HomeServiceId { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public OrderStatusEnum Status { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string? Description { get; set; }
        public DateTime DateOfExecution { get; set; }
        #endregion Properties

        #region Navigation properties
        public Customer? Customer { get; set; }
        public List<Image>? Images { get; set; }
        public List<Suggestion>? Suggestions { get; set; }
        public HomeService? HomeService { get; set; }

        #endregion Navigation properties
    }
}
