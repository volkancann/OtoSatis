using System.ComponentModel.DataAnnotations;

namespace OtoSatisServis.WebUI.Models
{
    public class CustomerLoginViewModel
    {
        [Display(Name = "Email"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Email { get; set; }

        [Display(Name = "Şifre"), StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Sifre { get; set; }
    }
}
