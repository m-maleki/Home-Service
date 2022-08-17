namespace HS.Domain.Core.Entities
{
    public class Image
    {
        #region Properties

        public int Id { get; set; }
        public int OrderId { get; set; }
        public string? Name { get; set; }
        public string? Alt { get; set; }
        public string? Url { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;

        #endregion Properties

        #region Navigation properties

        public Order? Order { get; set; }

        #endregion Navigation properties
    }
}
