
namespace HS.Domain.Core.Entities
{
    public class HomeServiceCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<HomeService>? HomeServices { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime RegisterDate { get; set; } = DateTime.Now;
    }

}
