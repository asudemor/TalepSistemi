using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly AppDbContext _context;
        public TalepController(AppDbContext context)
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
        public IActionResult TalepOlustur(Talep talep) //gorevi veritabanına kaydetmek
        {
            if (!ModelState.IsValid)
            {
                return View("TalepOlustur");
            }
            _context.Talepler.Add(talep);
            _context.SaveChanges();
            return RedirectToAction("BekleyenTalep");
        }



        public async Task<IActionResult> Listele()
        {
           return View(await _context.Talepler.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                var talep = _context.Talepler.Where(x => x.TalepID == id).SingleOrDefault();
                if (talep == null) { return NotFound(); }
                return View(talep);
            }
            return NotFound();
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
            _context.SaveChanges();
            return RedirectToAction("BekleyenTalep");
        }

        public IActionResult Delete(int id)
        {
            var talep = _context.Talepler.Where(x => x.TalepID == id).SingleOrDefault();
            _context.Talepler.Remove(talep);
            _context.SaveChanges();
            return RedirectToAction("BekleyenTalep");
        }

        public IActionResult YanitlananTalep()
        {
            return View();
        }
        public async Task<IActionResult> BekleyenTalep()
        {
            return View(await _context.Talepler.ToListAsync());
        }
    }
}

