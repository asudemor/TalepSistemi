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
            return View();
        }
        public async Task<IActionResult> AdminYeniTalepler()
        {
            return View(await _context.Talepler.ToListAsync());
        }
    }
}
