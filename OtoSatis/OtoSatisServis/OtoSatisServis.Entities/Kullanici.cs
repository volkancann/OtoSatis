

using System.ComponentModel.DataAnnotations;

namespace OtoSatisServis.Entities
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Display(Name = "Ad"),Required(ErrorMessage ="{0} Boş Bırakılamaz!")]
        public string Adi { get; set; }
        [Display(Name = "SoyAd"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Soyadi { get; set; }
        [Display(Name = "Email"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Email { get; set; }
        public string? Telefon { get; set; }
       
        public string? KullaniciAdi { get; set; }
        [Display(Name = "Şifre"),StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Sifre { get; set; }
        public bool AktifMi { get; set; }
        [Display(Name = "EklenmeTarihi"),ScaffoldColumn(false)]
        public DateTime EklenmeTarihi { get; set; }
        [Display(Name = "Kullanıcı Rolü"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public int RolId { get; set; }
        [Display(Name = "Kullanıcı Rolü")]
        public virtual Rol? Rol { get; set; }
        public Guid? UserGuid { get; set; } = Guid.NewGuid();
    }
}
