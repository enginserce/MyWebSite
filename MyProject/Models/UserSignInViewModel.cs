using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyProject.Models
{
    public class UserSignInViewModel
    {
        [Display(Name = "Kullanıcı adı")]
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]
        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [Compare("Password", ErrorMessage = "Lütfen şifrenizi giriniz.")]
        public string Password { get; set; }
    }
}
