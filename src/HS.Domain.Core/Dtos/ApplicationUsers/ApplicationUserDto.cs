

namespace HS.Domain.Core.Dtos.ApplicationUsers
{
    public class ApplicationUserDto
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }=string.Empty;
        public string? UserName { get; set; }=string.Empty;
        public string? Password { get; set; } = string.Empty;
        public string? ConfirmPassword { get; set; } = string.Empty;
        public string? Role { get; set; }
        public string? ProfileImgUrl { get; set; }
        public string? ProfileImgUrlCustomer { get; set; }
        public bool EmailConfirmed { get; set; }
        public List<string> Roles { get; set; }
    }
}
