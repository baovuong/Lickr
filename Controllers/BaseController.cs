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
    public abstract class BaseController : Controller
    {
        public void AddMessage(string message, MessageType type = MessageType.DEFAULT)
        {
            if (ViewBag.Messages == null)
            {
                ViewBag.Messages = new List<StatusMessage>();
            }

            ViewBag.Messages.Add(new StatusMessage
            {
                Message = message,
                Type = type
            });
        }
    }
}