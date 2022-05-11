﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalepSistemi.Models;

namespace TalepSistemi.Data
{
    public class TalepData
    {
        public List<Talep> Talepler = new List<Talep>
        {
            new Talep{
                    TalepID=1,
                    TalepGonderen="pelincerkez",
                    TalepDepartman = "Insan Kaynakları",
                    TalepKonu = "Deneme",
                    TalepAciklama = "DENEMEDENEME",
                    TalepTarih = DateTime.Now,
                    TalepDurum = false,
                    ImageUrl = "deneme1.jpg"
                },

                new Talep{
                    TalepID=2,
                    TalepGonderen="asudemor",
                    TalepDepartman = "Insan Kaynakları",
                    TalepKonu = "Deneme2",
                    TalepAciklama = "DENEMEDENEME2",
                    TalepTarih = DateTime.Now,
                    TalepDurum = false,
                    ImageUrl = "deneme2.jpg"
                }
        };
    }
}