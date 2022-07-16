using HS.Domain.Core.Entities;
using System.Collections.ObjectModel;

namespace HS.EndPoints.RazorPages.ShopUI.Model
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Biography { get; set; }
        public string? ProfileImgUrl { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ShebaNumber { get; set; }
        public string? CardNumber { get; set; }
        public string? Address { get; set; }
        public int Score { get; set; }
        public List<string>? Role { get; set; }
        public string? Roles { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

    }
}
