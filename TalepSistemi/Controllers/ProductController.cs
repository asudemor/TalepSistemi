using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalepSistemi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //localhost:39466/product/list
        public string list()
        {
            return "product/list";
        }
        //localhost:39466/product/details
        public string details()
        {
            return "product/details";
        }
    }
}
