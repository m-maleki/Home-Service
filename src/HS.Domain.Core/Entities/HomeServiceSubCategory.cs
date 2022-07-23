
namespace HS.Domain.Core.Entities
{
    public class HomeServiceSubCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int HomeServiceCategoryId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime RegisterDate { get; set; } = DateTime.Now;

        public HomeServiceCategory? HomeServiceCategory { get; set; }
        public List<HomeService>? HomeServices { get; set; }
    }
}
