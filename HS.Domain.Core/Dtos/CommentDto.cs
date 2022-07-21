using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Dtos
{
    public class CommentDto
    {
        #region Properties
        public int Id { get; set; }
        public string? Body { get; set; }
        public int Score { get; set; }
        public Guid ExpertId { get; set; }
        #endregion Properties
        #region Navigation properties
        public Expert? Expert { get; set; }
        #endregion Navigation properties
    }
}
