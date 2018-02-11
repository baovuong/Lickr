using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lickr.Models;
using Lickr.Dispensers;
using Blog.DotNetCoreMongoDb.Repository;

namespace Lickr.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ISongDispenser _songDispenser;
    
        public HomeController(ISongDispenser songDispenser)
        {
            _songDispenser = songDispenser;
        }
    
        public IActionResult Index()
        {
            return View(_songDispenser.Dispense());
        } 

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
    }
}
