﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TalepSistemi.Data;
using TalepSistemi.Models;

namespace TalepSistemi.Controllers
{
    public class TalepController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnviroment;

        public TalepController(AppDbContext context, IWebHostEnvironment hostEnviroment)
        {
            _context = context;
            _hostEnviroment = hostEnviroment;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult TalepOlustur()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TalepOlustur(Talep talep) //gorevi veritabanına kaydetmek
        {
            if (!ModelState.IsValid)
            {
                return View("TalepOlustur");
            }
            if (talep.Dosya != null)
            {
                var dosyaYolu = Path.Combine(_hostEnviroment.WebRootPath, "resimler");
                if (!Directory.Exists(dosyaYolu))
                {
                    Directory.CreateDirectory(dosyaYolu);
                }

                var tamDosyaAdi = Path.Combine(dosyaYolu, talep.Dosya.FileName);
                using (var dosyaAkisi = new FileStream(tamDosyaAdi, FileMode.Create))
                {
                    await talep.Dosya.CopyToAsync(dosyaAkisi);
                }

                talep.ImageUrl = talep.Dosya.FileName;
            }

            _context.Talepler.Add(talep);
            _context.SaveChanges();
            return RedirectToAction("BekleyenTalep");
        }

        //public async Task<IActionResult> Listele()
        //{
        //   return View(await _context.Talepler.ToListAsync());
        //}

        public IActionResult Listele(string? username)
        {
            //username = "asudemor"; //Otomatik gelmesi gerekli.
            List<Talep> gonderenTalep = _context.Talepler.Where(x => x.TalepGonderen == username).ToList();
            //var listele = _context.Talepler.Where(x => x.TalepGonderen == username).ToList();
            //return View(listele);
            return View(gonderenTalep);
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
            if (!ModelState.IsValid)
            {
                return View("Edit");
            }
            if (talep.Dosya != null)
            {
                var dosyaYolu = Path.Combine(_hostEnviroment.WebRootPath, "resimler");
                if (!Directory.Exists(dosyaYolu))
                {
                    Directory.CreateDirectory(dosyaYolu);
                }

                var tamDosyaAdi = Path.Combine(dosyaYolu, talep.Dosya.FileName);
                using (var dosyaAkisi = new FileStream(tamDosyaAdi, FileMode.Create))
                {
                    await talep.Dosya.CopyToAsync(dosyaAkisi);
                }

                talep.ImageUrl = talep.Dosya.FileName;
            }
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
        public IActionResult BekleyenTalep()
        {
            var talep = _context.Talepler.Where(x => x.TalepDurum == false).ToList();
            if (talep == null) { return NotFound(); }
            return View(talep);
        }
    }
}

