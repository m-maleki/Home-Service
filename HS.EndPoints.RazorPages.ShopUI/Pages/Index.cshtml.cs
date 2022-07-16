using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HS.EndPoints.RazorPages.ShopUI.Pages
{

    [Authorize]
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
            return LocalRedirect("/Admin");
        }
    }
}
