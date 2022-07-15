using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Dtos
{
    public class HomeServiceCategoryDto
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        #endregion Properties

        #region Navigation properties  
        public List<HomeService>? HomeServices { get; set; }
        #endregion Navigation properties
    }
}
