using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HS.EndPoints.RazorPages.ShopUI.Model
{
    public class RegisterViewModel 
    {
        [PageRemote(
            ErrorMessage = "آدرس ایمیل وارد شده تکراری می باشد",
            AdditionalFields = "__RequestVerificationToken",
            HttpMethod = "get",
            PageHandler = "CheckEmail"
        )]
        [BindProperty]
        [Required(ErrorMessage = "وارد کردن {0} اجباری می باشد")]
        [EmailAddress(ErrorMessage = "* آدرس ایمیل معتبر نمی باشد")]
        [Display(Name = "آدرس ایمیل")]
        public string Email { get; set; }

        [Required(ErrorMessage = "وارد کردن {0} اجباری می باشد")]
        [StringLength(16, ErrorMessage = "* کلمه عبور باید حداقل 4 و حداکثر 16 کاراکتر باشد", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "وارد کردن {0} اجباری می باشد")]
        [Display(Name = "تکرار رمز عبور")]
        [Compare(nameof(Password), ErrorMessage = "* کلمه عبور و تکرار آن باید برابر باشند")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
