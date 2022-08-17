namespace HS.Domain.Core.Entities
{
    public class HomeServiceCategory
    {
        #region Properties

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string? ImgSrc { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;

        #endregion Properties

        #region Navigation properties

        public List<HomeServiceSubCategory>? HomeServiceSubCategories { get; set; }

        #endregion Navigation properties
    }

}
