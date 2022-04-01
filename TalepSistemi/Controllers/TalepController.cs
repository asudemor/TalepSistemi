using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalepSistemi.Models;

namespace TalepSistemi.Controllers
{
    public class TalepController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TalepOlustur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TalepOlustur(Talep t)
        {
            return View();
        }
        public IActionResult Listele()
        {
            var talepler = new List<Talep>()
            {
                new Talep(){
                    TalepID=1,
                    TalepGonderenID=1,
                    TalepDepartman = "Insan Kaynakları",
                    TalepKonu = "Deneme",
                    TalepAciklama = "DENEMEDENEME",
                    TalepTarih = DateTime.Now,
                    TalepDurum = false
                }
            };
            return View(talepler);
        }
        public IActionResult Details()
        {
            var t = new Talep();
            t.TalepID = 1;
            t.TalepGonderenID = 1;
            t.TalepDepartman = "Insan Kaynakları";
            t.TalepKonu = "Deneme";
            t.TalepAciklama = "DENEMEDENEME";
            t.TalepTarih = DateTime.Now;
            t.TalepDurum = false;

            return View(t);
        }
    }
}

