using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Controllers
{
    public class Challenge1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Message(string challengeName, int activityNumber = 2)
        {
            ViewBag.ChallengeName = challengeName;
            ViewBag.ActivityNumber = activityNumber;
            return View();
        }
    }
}
