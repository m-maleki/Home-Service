using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace HS.EndPoints.RazorPages.ShopUI.Model
{
    public class RegisterViewModel 
    {
        [Required]
        [EmailAddress(ErrorMessage ="* آدرس ایمیل معتبر نمی باشد")]
        [Display(Name = "آدرس ایمیل")]
        public string Email { get; set; }
        [Required]
        [StringLength( 16,ErrorMessage ="* کلمه عبور باید حداقل 3 و حداکثر 16 کاراکتر باشد" ,MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name ="رمز عبور")]
        [BindProperty]
        public string Password { get; set; }
        [Compare(nameof(Password),ErrorMessage ="* کلمه عبور و تکرار آن باید برابر باشند")]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string ConfirmPassword { get; set; }
    }
}
