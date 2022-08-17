namespace HS.Domain.Core.Dtos
{
    public class ImageDto
    {
        #region Properties

        public int Id { get; set; }
        public int OrderId { get; set; }
        public string? Name { get; set; }
        public string? Alt { get; set; }
        public string? Url { get; set; }

        #endregion Properties
    }
}
