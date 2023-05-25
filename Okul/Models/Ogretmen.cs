using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Okul.Models
{
    public class Ogretmen
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string AdSoyad { get; set; }

        [Required]
        [StringLength(6)]
        public string Cinsiyet { get; set; }

        [Required]
        public int Yas { get; set; }

        [Required]
        [Range(1,25,ErrorMessage ="Geçersiz")]
        [DisplayName("Çalışma Yıl")]
        public int ToplamTecrube { get; set; }
    }
}
