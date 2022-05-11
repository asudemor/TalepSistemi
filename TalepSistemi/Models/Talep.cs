using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TalepSistemi.Models
{
    public class Talep
    {
        public int TalepID { get; set; }
        //public int TalepGonderenID { get; set;}

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
        public string TalepGonderen { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
        public string TalepDepartman { get; set; }

        [Required (ErrorMessage = "{0} alanı boş bırakılamaz.")]
        public string TalepKonu { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
        public string TalepAciklama { get; set; }
        public bool TalepDurum { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy.MM.dd}" , ApplyFormatInEditMode =false)]
        public DateTime TalepTarih { get; set; }
        public string ImageUrl { get; set; }
    }
}
