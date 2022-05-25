using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TalepSistemi.Data;
using TalepSistemi.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace TalepSistemi.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnviroment;

        public object Session { get; private set; }

        public HomeController(AppDbContext context, IWebHostEnvironment hostEnviroment)
        {
            _context = context;
            _hostEnviroment = hostEnviroment;
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Control(string username, string pass)
        {
            var kisi = _context.Kullanicilar.Where(x => x.KullaniciAdi == username && x.Sifre == pass).SingleOrDefault();
            if (kisi != null)
            {
                ViewBag.username = kisi.KullaniciAdi;
                HttpContext.Session.SetString("user", JsonConvert.SerializeObject(kisi));
                if (kisi.Adminlik == true){return RedirectToAction("AdminYeniTalepler", "Admin");}
                else{return RedirectToAction("Listele","Talep");}
            }
            else{return RedirectToAction("Login");}
        }

        public IActionResult Profil()
        {
            var kisiVeri = HttpContext.Session.GetString("user");
            var kullanici = JsonConvert.DeserializeObject<Kullanici>(kisiVeri);
            ViewBag.kisiVeri = kullanici.KullaniciAdi;
            ViewBag.kisiVeri2 = kullanici.Adminlik;
            ViewBag.kisiVeri3 = kullanici.Fotograf;
            ViewBag.kisiVeri4 = kullanici.Konum;
            return View();
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
