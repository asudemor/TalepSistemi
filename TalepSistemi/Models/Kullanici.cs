using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TalepSistemi.Models
{
    public class Kullanici
    {
        public int id { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
        public string Sifre { get; set; }
        public bool Adminlik { get; set; }
    }
}
