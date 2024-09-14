using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoSatisServis.Entities
{
    public class Musteri : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Araç")]
        public int AracId { get; set; }
        [StringLength(50)]
        [Display(Name = "Ad") , Required(ErrorMessage ="{0} Boş Bırakılamaz!")]
        public string Adi { get; set; }
        [StringLength(50)]
        [Display(Name = "SoyAd"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Soyadi { get; set; }
        [StringLength(50)]
        [Display(Name = "Tc"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string? TcNo { get; set; }
        [StringLength(50)]
        [Display(Name = "Email"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Email { get; set; }
        [StringLength(500)]
        public string? Adres { get; set; }
        [StringLength(15)]
        public string? Telefon { get; set; }
        public string? Notlar { get; set; }
        [Display(Name = "Araç")]
        public virtual Arac? Arac { get; set; }
    }
}
