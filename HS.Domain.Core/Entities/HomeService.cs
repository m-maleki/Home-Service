namespace HS.Domain.Core.Entities
{
    public class HomeService
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImgUrl { get; set; }
        public double Price { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        #endregion Properties
        #region Navigation properties
        public HomeServiceCategory? HomeServiceCategory { get; set; }
        public Order? Orders { get; set; }
        public List<Expert>? Experts { get; set; }
        #endregion Navigation properties
    }
}
