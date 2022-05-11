﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TalepSistemi.Models
{
    public class Talep
    {
        public int TalepID { get; set; }
        //public int TalepGonderenID { get; set; }
        public string TalepGonderen { get; set; }
        public string TalepDepartman { get; set; }

        [Required]
        public string TalepKonu { get; set; }
        [Required]
        public string TalepAciklama { get; set; }
        public bool TalepDurum { get; set; }
        public DateTime TalepTarih { get; set; }

        //Eklenti(.doc,.pdf,.jpg) vb.
        public string ImageUrl { get; set; }
    }
}
