namespace HS.Domain.Core.Entities
{
    public class HomeService
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public int? HomeServiceSubCategoryId { get; set; }
        public string? ImgSrc { get; set; }
        public double BasePrice { get; set; }

        #endregion Properties

        #region Navigation properties

        public HomeServiceSubCategory? HomeServiceSubCategory { get; set; }
        public List<Order> Orders { get; set; }
        public List<Expert>? Experts { get; set; } = new List<Expert>();

        #endregion Navigation properties
    }
}
