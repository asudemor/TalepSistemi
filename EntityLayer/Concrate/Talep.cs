using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Talep
    {
        [Key]
        public int TalepID { get; set; }
        public int TalepGonderenID { get; set; }
        public string TalepDepartman { get; set; }
        public string TalepKonu { get; set; }
        public string TalepAciklama { get; set; }
        public bool TalepDurum { get; set; }
        public DateTime TalepTarih { get; set; }
        //Eklenti(.doc,.pdf,.jpg) vb.
        public string ImageUrl { get; set; }
    }
}
