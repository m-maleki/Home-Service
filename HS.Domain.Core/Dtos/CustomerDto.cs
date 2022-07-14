using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Dtos
{
    public class CustomerDto
    {
        #region Properties
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public string? ProfileImgUrl { get; set; }
        public string? Address { get; set; }
        public DateTime Birthday { get; set; }
        public Guid IdentityId { get; set; }
        #endregion Properties
        #region Navigation properties
        public List<Order>? Orders { get; set; }
        #endregion Navigation properties
    }
}