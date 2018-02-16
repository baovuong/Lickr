using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lickr.Dispensers;

namespace Lickr.Controllers
{
    public class ManagementController : BaseController
    {
        private readonly ISongDispenser _songDispenser;
        public ManagementController(ISongDispenser songDispenser)
        {
            _songDispenser = songDispenser;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Enable(int id)
        {
            return Json("enabling song " + id);
        }

        [HttpPost]
        public IActionResult Disable(int id)
        {
            return Json("disabling song " + id);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return Json("deleting song " + id);
        }
    }
}