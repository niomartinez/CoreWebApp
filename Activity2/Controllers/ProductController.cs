using Activity2.Models;
using Activity2.Services;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            HardCodedSampleDataRepository repo = new();
            return View(repo.GetAllProducts());
        }

        public IActionResult Message()
        {
            return View();
        }
        public IActionResult Welcome(string name, int secretNumber=13)
        {
            ViewBag.Name = name;
            ViewBag.Secret = secretNumber;
            return View();
        }
    }
}
