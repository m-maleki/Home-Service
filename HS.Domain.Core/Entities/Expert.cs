using System;
namespace HS.Domain.Core.Entities
{
    public class Expert
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Biography { get; set; }
        public string? ProfileImgUrl { get; set; }
        public string? PhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public string? Address { get; set; }
        public int Score { get; set; }
        public DateTime Birthday { get; set; }
        List<Specialty>? Specialties { get; set; }
        List<Order>? Orders { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
