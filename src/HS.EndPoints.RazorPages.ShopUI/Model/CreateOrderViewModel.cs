using HS.Domain.Core.Entities;

namespace HS.EndPoints.RazorPages.UI.Model
{
    public class CreateOrderViewModel
    {
        public int CustomerId { get; set; }
        public int HomeServiceId { get; set; }
        public DateTime RegisterDate { get; set; }= DateTime.Now;

        public Customer Customer { get; set; }
        public HomeService HomeService { get; set; }
        public List<HomeService> HomeServices { get; set; }

    }
}
