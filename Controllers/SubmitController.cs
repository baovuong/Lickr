using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            var items = Enum.GetValues(typeof(SourceType))
                .Cast<SourceType>()
                .Select(_ => new SelectListItem { Text = _.ToString(), Value = ((int)_).ToString() });
            
            return View(new SongSubmissionViewModel
            {
                SourceTypeItems = items
            });
        }

        public IActionResult Submit(SongSubmissionViewModel model)
        {
            return RedirectToAction("Index");
        }

        
    }
}