namespace HS.Domain.Core.Entities
{
    public class Suggestions
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ExpertId { get; set; }
        public double SuggestedPrice { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public DateTime DurationOfWork { get; set; }
    }
}
