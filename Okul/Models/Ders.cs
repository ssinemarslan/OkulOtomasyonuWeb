using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Okul.Models
{
    public class Ders
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string DersAdi { get; set; }

        [Required]
        [Range(0,10,ErrorMessage ="Geçerli kredi giriniz")]
        public int DersKredi { get; set; }

        
    }
}
