using HS.Domain.Core.Entities;
using Microsoft.AspNetCore.Http;

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
        public string? ShebaNumber { get; set; }
        public string? CardNumber { get; set; }
        public IFormFile? ProfileImgFile { get; set; }
        public string? ProfileImgUrl { get; set; }
        public string? Address { get; set; }
        public DateTime Birthday { get; set; }
        public Guid IdentityId { get; set; }
        #endregion Properties

        #region Navigation properties
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public List<Order>? Orders { get; set; }
        public int CityId { get; set; }
        public City? City { get; set; }
        #endregion Navigation properties
    }
}