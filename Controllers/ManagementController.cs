using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lickr.Dispensers;
using Lickr.Models;
using Lickr.GateKeepers;

namespace Lickr.Controllers
{
    public class ManagementController : BaseController
    {
        private readonly ISongDispenser _songDispenser;
        private readonly IGateKeeper _gateKeeper;
        public ManagementController(ISongDispenser songDispenser, IGateKeeper gateKeeper)
        {
            _songDispenser = songDispenser;
            _gateKeeper = gateKeeper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserCredentials model)
        {
            AddMessage("did the login");
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