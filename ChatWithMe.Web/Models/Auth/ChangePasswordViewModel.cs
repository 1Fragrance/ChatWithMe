using System.ComponentModel.DataAnnotations;
using ChatWithMe.Web.ValidationAttributes;

namespace ChatWithMe.Web.Models.Auth
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Old password is required")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "New password is required")]
        [NotEqual("OldPassword", ErrorMessage = "New password is equal to old password")]
        public string NewPassword { get; set; }
    }
}
