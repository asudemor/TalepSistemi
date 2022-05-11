using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalepSistemi.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Login(string username, string pass)
        {
            return View();
        }
    }
}
