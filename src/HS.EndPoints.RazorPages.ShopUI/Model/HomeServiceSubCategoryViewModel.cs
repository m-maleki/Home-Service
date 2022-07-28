using HS.Domain.Core.Entities;

namespace HS.EndPoints.RazorPages.UI.Model
{
    public class HomeServiceSubCategoryViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int HomeServiceCategoryId { get; set; }

        public HomeServiceCategory? HomeServiceCategory { get; set; }
        public List<HomeService>? HomeServices { get; set; }
    }
}
