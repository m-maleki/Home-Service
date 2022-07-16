namespace HS.Domain.Core.Entities
{
    public class Customer 
    {
        #region Properties
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public string? ProfileImgUrl { get; set; }
        public string? Address { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Guid ApplicationUserId { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public DateTime Birthday { get; set; }

        #endregion Properties

        #region Navigation properties
        public ApplicationUser? ApplicationUser { get; set; }
        public List<Order>? Orders { get; set; }
        public City? City { get; set; }
        #endregion Navigation properties
    }
}