using HS.Domain.Core.Entities;

namespace HS.EndPoints.RazorPages.UI.Model
{
    public class SuggestionViewModel
    {
        #region Properties
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Guid ExpertId { get; set; }
        public double SuggestedPrice { get; set; }
        public DateTime DurationOfWork { get; set; }
        public string? Description { get; set; }
        public DateTime RegisterDate { get; set; }

        #endregion Properties
        #region Navigation properties
        public Order? Order { get; set; }
        public Expert? Expert { get; set; }
        #endregion Navigation properties
    }
}
