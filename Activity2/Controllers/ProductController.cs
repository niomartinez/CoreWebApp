using Activity2.Models;
using Activity2.Services;
using Activity2.Services.Repositories;
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
            ProductsDAO products = new();
            return View(products.GetAllProducts());
        }
        public IActionResult SearchResults(string searchTerm)
        {
            ProductsDAO products = new();
            return View("Index", products.SearchProducts(searchTerm));
        }
        public IActionResult SearchForm()
        {
            return View();
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
