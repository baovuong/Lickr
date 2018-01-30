using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lickr.Models;
using Lickr.Dispensers;

namespace Lickr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISongDispenser _songDispenser;
    
        public HomeController(ISongDispenser songDispenser)
        {
            _songDispenser = songDispenser;
        }
    
        public IActionResult Index() => View(_songDispenser.Dispense());

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Submit()
        {
            return View();
        }
    }
}
