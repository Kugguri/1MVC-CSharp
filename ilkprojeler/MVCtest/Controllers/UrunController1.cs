using Microsoft.AspNetCore.Mvc;
using MVCtest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCtest.Controllers
{
    public class UrunController1 : Controller
    {
        public IActionResult UrunleriAl()
        {
            Urun urun = new Urun();

            //veri oluştu
            ViewResult result = View();

            return View();
        }
    }
}
