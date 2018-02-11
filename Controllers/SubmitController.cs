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
            if (ModelState.IsValid)
            {
                return View(model);
            }
            var valid = _handlerResolver(model.Type).Validate(new Song
            {
                Source = model.Source,
                Start = model.Start,
                End = model.End
            });
            if (!valid)
            {
                AddMessage("invalid values. try again.", MessageType.ERROR);
                return View(model);
            }
            AddMessage("song has been submitted!", MessageType.SUCCESS);
            return RedirectToAction("Index");
        }

        
    }
}