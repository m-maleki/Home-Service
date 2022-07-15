using System.Collections.ObjectModel;

namespace HS.EndPoints.RazorPages.ShopUI.Model
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public List<string>? Role { get; set; }
        public string? Roles { get; set; }

    }
}
