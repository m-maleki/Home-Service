using HS.Domain.Core.Contracts.ApplicationService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web.Mvc;

namespace HS.EndPoints.RazorPages.UI.Areas.Account.Pages
{
    public class emailConfirmationModel : PageModel
    {
        private readonly IApplicationUserApplicationService _applicationUserApplicationService;
        public string Message;
        public emailConfirmationModel(IApplicationUserApplicationService applicationUserApplicationService)
        {
            _applicationUserApplicationService = applicationUserApplicationService;
        }

        public async Task OnGet(string confirmKey)
        {
           if(await _applicationUserApplicationService.confirmEmail(confirmKey))
                Message = "حساب کاربری شما با موفقیت فعال شد";
           else 
                Message = "کد فعال سازی نامعتبر می باشد";
        }
    }
}
