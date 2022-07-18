using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Dtos
{
    public class HomeServiceDto
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImgSrc { get; set; }
        public double Price { get; set; }
        public int? HomeServiceSubCategoryId { get; set; }

        #endregion Properties
        #region Navigation properties
        public HomeServiceCategory? HomeServiceCategory { get; set; }
        public Order? Orders { get; set; }
        #endregion Navigation properties
    }
}
