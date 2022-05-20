using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnviroment;

        public AdminController(AppDbContext context, IWebHostEnvironment hostEnviroment)
        {
            _context = context;
            _hostEnviroment = hostEnviroment;
        }
        public IActionResult AdminIndex()
        {
            return View();
        }
        public IActionResult AdminProfil()
        {
            return View();
        }
        public IActionResult AdminSonuclananTalepler()
        {
            var talep = _context.Talepler.Where(x => x.TalepDurum == true).ToList();
            if (talep == null) { return NotFound(); }
            return View(talep);
        }
        public IActionResult AdminYeniTalepler()
        {
            var talep = _context.Talepler.Where(x => x.TalepDurum == false).ToList();
            if (talep == null) { return NotFound(); }
            return View(talep);
        }
        public IActionResult TalepDurumEdit(int id)
        {
            var talep = _context.Talepler.SingleOrDefault(x => x.TalepID == id);
            return View(talep);
        }
        [HttpPost]
        public async Task<IActionResult> TalepDurumEdit(Talep talep)
        {
            if (!ModelState.IsValid)
            {
                return View("TalepDurumEdit");
            }
            var guncellenecekTalep = _context.Talepler.SingleOrDefault(x => x.TalepID == talep.TalepID);
            await TryUpdateModelAsync(guncellenecekTalep);
            _context.SaveChanges();
            return RedirectToAction("AdminYeniTalepler");
        }
    }
}
