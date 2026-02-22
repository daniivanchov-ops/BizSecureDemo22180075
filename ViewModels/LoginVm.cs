using System.ComponentModel.DataAnnotations;

namespace BizSecureDemo22180075.ViewModels
{
    public class LoginVm
    {
        [Required, EmailAddress]
        public string Email { get; set; } = "";
        [Required]
        public string Password { get; set; } = "";
    }

}
