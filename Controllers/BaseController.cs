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
            List<StatusMessage> messages = TempData.ContainsKey("Messages") ? TempData["Messages"] as List<StatusMessage> : new List<StatusMessage>();
            messages.Add(new StatusMessage
            {
                Message = message,
                Type = type
            });
            TempData["Messages"] = messages;
        }
    }
}