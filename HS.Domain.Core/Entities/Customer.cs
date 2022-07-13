using Microsoft.AspNetCore.Identity;

namespace HS.Domain.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public string? ProfileImgUrl { get; set; }
        public string? Address { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public List<Order>? Orders { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public int ApplicationUserId { get; set; }
    }
}
