using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace duladu.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            RedirectToActionResult redirectResult = new RedirectToActionResult("Seller", "Home", new { });
            return redirectResult;
        }

        [Route("Seller")]
        public IActionResult Seller()
        {
            return View();
        }

        [Route("Buyer")]
        public IActionResult Buyer()
        {

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
