using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalepSistemi.Data;
using TalepSistemi.Models;

namespace TalepSistemi.Controllers
{
    public class TalepController : Controller
    {
        private readonly TalepData _context;
        public TalepController(TalepData context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TalepOlustur()
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult TalepOlustur()   
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult TalepOlustur(Talep talep)      //gorevi veritabanına kaydetmek
        {
            _context.Talepler.Add(talep);
            return RedirectToAction("BekleyenTalep");
        }

        public IActionResult Listele()
        {
           return View(_context.Talepler);
        }

        public IActionResult Details(int id)
        {
            var talep = _context.Talepler.Where(x => x.TalepID == id).SingleOrDefault();
            return View(talep);
        }


        public IActionResult Edit(int id)
        {
            var talep = _context.Talepler.SingleOrDefault(x => x.TalepID == id);
            return View(talep);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Talep talep)
        {
            var guncellenecekTalep = _context.Talepler.SingleOrDefault(x => x.TalepID == talep.TalepID);
            await TryUpdateModelAsync(guncellenecekTalep);
            return RedirectToAction("BekleyenTalep");
        }




        public IActionResult Delete(int id)
        {
            var talep = _context.Talepler.Where(x => x.TalepID == id).SingleOrDefault();
            _context.Talepler.Remove(talep);
            return RedirectToAction("BekleyenTalep");
        }

        public IActionResult YanitlananTalep()
        {
            return View();
        }

        public IActionResult BekleyenTalep()
        {
            return View(_context.Talepler);
        }
    }
}

