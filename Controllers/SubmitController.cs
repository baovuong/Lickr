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
    public class SubmitController : Controller
    {
        private readonly ISongDispenser _songDispenser;

        public SubmitController(ISongDispenser songDispenser)
        {
            _songDispenser = songDispenser;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Submit(SongSubmissionViewModel model)
        {
            return RedirectToAction("Index");
        }
    }
}