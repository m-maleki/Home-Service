using System.ComponentModel.DataAnnotations;

namespace HS.EndPoints.RazorPages.ShopUI.Model
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "* آدرس ایمیل معتبر نمی باشد")]
        [Display(Name = "آدرس ایمیل")]
        public string? Email { get; set; }
        [Required]
        [StringLength(16, ErrorMessage = "* کلمه عبور باید حداقل 3 و حداکثر 16 کاراکتر باشد", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string? Password { get; set; }

        public bool RemomberMe { get; set; }
    }
}
