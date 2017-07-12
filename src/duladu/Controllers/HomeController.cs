using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace duladu.Controllers
{
    public class HomeController : Controller
    {
        [Route("Seller")]
        public IActionResult Seller()
        {
            ViewData["Message"] = "Seller";

            return View();
        }

        [Route("Buyer")]
        public IActionResult Buyer()
        {
            ViewData["Message"] = "Buyer";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
