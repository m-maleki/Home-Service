namespace HS.Domain.Core.Entities
{
    public class Comment
    {
        #region Properties
        public int Id { get; set; }
        public string? Body { get; set; }
        public int? Score { get; set; }
        public Guid ExpertId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        #endregion Properties

        #region Navigation properties
        public Expert? Expert { get; set; }
        #endregion Navigation properties
    }
}
