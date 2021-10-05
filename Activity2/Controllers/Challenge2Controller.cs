using Activity2.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Controllers
{
    public class Challenge2Controller : Controller
    {
        public IActionResult Index()
        {
            CarRepository car = new();
            return View(car.GetAllCars());
        }
    }
}
