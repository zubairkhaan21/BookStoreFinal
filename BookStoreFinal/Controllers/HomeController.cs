using BookStoreFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //dynamic data = new ExpandoObject();
            //data.Id = 1;
            //data.Name = "Zubair";
            //ViewBag.Data = data;

            //ViewBag.Type = new BookModel()
            //{
            //    Id = 1,
            //    Author = "Muhammad"
            //};

            //ViewData["prop1"] = new BookModel() { Id = 1,Author = "Zubair"};

            ViewData["CustomProperty"] = "Custom Value";
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
