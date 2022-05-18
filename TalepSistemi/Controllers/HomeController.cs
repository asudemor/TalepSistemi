using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TalepSistemi.Data;
using TalepSistemi.Models;

namespace TalepSistemi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnviroment;
        public HomeController(AppDbContext context, IWebHostEnvironment hostEnviroment)
        {
            _context = context;
            _hostEnviroment = hostEnviroment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult Kullanici()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Control(string username,string pass)
        {
            List<Kullanici> kullanici = new List<Kullanici>();
            var kisi = _context.Kullanicilar.Where(x => x.KullaniciAdi == username && x.Sifre == pass).SingleOrDefault();
            kullanici.Add(kisi);
            if (kisi==null)
            {
                return RedirectToAction("Login");
            }
            if (kisi.Adminlik==true)
            {
                return RedirectToAction("AdminIndex","Admin");
            }
           
            else
            {
                return RedirectToAction("Kullanici");
            }
        }
        public IActionResult Profil()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
