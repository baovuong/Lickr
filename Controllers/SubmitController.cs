using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lickr.Models;
using Lickr.Dispensers;
using Lickr.SongHandlers;

namespace Lickr.Controllers
{
    public class SubmitController : BaseController
    {
        private readonly ISongDispenser _songDispenser;
        private readonly Func<SourceType, ISongHandler> _handlerResolver;

        public SubmitController(ISongDispenser songDispenser, Func<SourceType, ISongHandler> handlerResolver)
        {
            _songDispenser = songDispenser;
            _handlerResolver = handlerResolver;
        }

        public IActionResult Index()
        {
            return View(new SongSubmissionViewModel
            {
                SourceTypeItems = Enum.GetValues(typeof(SourceType))
                    .Cast<SourceType>()
                    .Select(_ => new SelectListItem { Text = _.ToString(), Value = ((int)_).ToString() })
            });
        }

        public IActionResult Submit(SongSubmissionViewModel model)
        {
            var handler = _handlerResolver(model.Type);
            AddMessage("woo!");
            return RedirectToAction("Index");
        }

        
    }
}