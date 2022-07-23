using HS.Domain.Core.Entities;

namespace HS.EndPoints.RazorPages.UI.Model
{
    public class HomeServiceViewModel
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImgSrc { get; set; }
        public double Price { get; set; }
        public int? HomeServiceSubCategoryId { get; set; }
        public double BasePrice { get; set; }


        #endregion Properties
        #region Navigation properties
        public List<HomeService>? HomeServices { get; set; }
        public HomeServiceSubCategory? HomeServiceSubCategory { get; set; }
        public HomeServiceCategory? HomeServiceCategory { get; set; }
        public Order? Orders { get; set; }
        #endregion Navigation properties
    }
}
