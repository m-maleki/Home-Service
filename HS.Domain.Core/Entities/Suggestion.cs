namespace HS.Domain.Core.Entities
{
    public class Suggestion
    {
        #region Properties
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string? Description { get; set; }
        public Guid ExpertId { get; set; }
        public double SuggestedPrice { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public DateTime DurationOfWork { get; set; }
        public bool IsAccept { get; set; } = false;
        public bool IsDeleted { get; set; } = false;

        #endregion Properties
        #region Navigation properties
        public Order? Order { get; set; }
        public Expert? Expert { get; set; }
        #endregion Navigation properties
    }
}
