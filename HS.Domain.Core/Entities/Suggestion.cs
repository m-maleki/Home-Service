using System.ComponentModel.DataAnnotations.Schema;

namespace HS.Domain.Core.Entities
{
    public class Suggestion
    { 
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ExpertId { get; set; }
        public double SuggestedPrice { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public DateTime DurationOfWork { get; set; }
        public Order? Order { get; set; }
        public Expert? Expert { get; set; }
        public bool IsAccept { get; set; } = false;

    }
}
