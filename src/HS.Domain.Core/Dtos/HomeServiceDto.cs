using HS.Domain.Core.Entities;
using Microsoft.AspNetCore.Http;

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
        public double BasePrice { get; set; }
        public bool IsDeleted { get; set; }
        public IFormFile? ImgFile { get; set; }

        #endregion Properties

        #region Navigation properties

        public HomeServiceCategory? HomeServiceCategory { get; set; }
        public HomeServiceSubCategory? HomeServiceSubCategory { get; set; }
        public Order? Orders { get; set; }

        #endregion Navigation properties
    }
}
