using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Okul.Models

{
    public class Ogrenci
    {
        [Key] //primary key yapacağımız alan anşlamına gelir.
        public int Id { get; set; }

        [Required] //yazılması gerekli boş geçilmez
        [StringLength(20)]
        public string AdSoyad { get; set; }

        [Required]
        [StringLength(6)]
        public string Cinsiyet { get; set; }

        [Required]
        [Range(25,55,ErrorMessage ="bu öğrencinin yaşı uygun değildir")]
        public int Yas { get; set; }

        

    }
}
