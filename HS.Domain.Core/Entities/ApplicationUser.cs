

using Microsoft.AspNetCore.Identity;

namespace HS.Domain.Core.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public Customer? Customer { get; set; }
        public Expert? Expert { get; set; }
    }
}
