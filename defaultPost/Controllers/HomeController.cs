using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using defaultPost.Models;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace defaultPost.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //[HttpGet]
        public IActionResult Index()
        {
            StreamReader stream = new StreamReader(HttpContext.Request.Body);
            string body = stream.ReadToEnd();
            ViewData["id2"] = body;
            return View();
        }
        //[HttpPost]
        //public IActionResult Index()
        //{
        //    var formdata = Request.Form["form1"];
        //    return View("/Home/Index");
        //}

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
