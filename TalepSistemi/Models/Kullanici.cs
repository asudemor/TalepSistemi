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
        public string KullaniciAdi { get; set; }

        [DataType(DataType.Password)]
        public string Sifre { get; set; }
        public bool Adminlik { get; set; }
        public string Konum { get; set; }
        public string Fotograf { get; set; }

    }
}
