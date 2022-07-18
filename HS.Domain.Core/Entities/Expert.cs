namespace HS.Domain.Core.Entities
{
    public class Expert
    {
        #region Properties
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Biography { get; set; }
        public string? ProfileImgUrl { get; set; }
        public string? Address { get; set; }
        public string? ShebaNumber { get; set; }
        public string? CardNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public int Score { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Guid ApplicationUserId { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public int? CityId { get; set; }
        #endregion Properties

        #region Navigation properties
        public DateTime Birthday { get; set; }
        public List<HomeService>? HomeServices { get; set; } = new List<HomeService>();
        public List<Suggestion>? Suggestion { get; set; }
        public List<Comment>? Comments { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public City? City { get; set; }
        #endregion Navigation properties
    }
}
