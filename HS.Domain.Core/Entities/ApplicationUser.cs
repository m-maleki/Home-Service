using Microsoft.AspNetCore.Identity;

namespace HS.Domain.Core.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        #region Navigation properties
        public Customer? Customer { get; set; }
        public Expert? Expert { get; set; }
        #endregion Navigation properties
    }
}
