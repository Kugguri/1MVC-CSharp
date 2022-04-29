using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCtest.Controllers
{
    public class OgrencilerController1 : Controller
    {
        public IActionResult OgrAl()
        {
            return View();
        }
    }
}
