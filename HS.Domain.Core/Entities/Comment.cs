
namespace HS.Domain.Core.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
        public int Score { get; set; }
        public int ExpertId { get; set; }
        public Expert? Expert { get; set; }
    }
}
