using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using Task4_StateAndFiles.Models;

namespace Task4_StateAndFiles.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SetData()
        {
            HttpContext.Response.Cookies.Append("UserName", "Anna");
            HttpContext.Session.SetString("Greeting", "Hello from session!");
            return RedirectToAction("GetData");
        }

        public IActionResult GetData()
        {
            ViewBag.Name = HttpContext.Request.Cookies["UserName"];
            ViewBag.Message = HttpContext.Session.GetString("Greeting");
            return View();
        }

        public IActionResult WriteFile()
        {
            string path = "wwwroot/data.txt";
            System.IO.File.WriteAllText(path, "Saved at: " + DateTime.Now);
            return Content("File saved.");
        }

        public IActionResult SetFavoriteColor(string color = "blue")
        {
            HttpContext.Response.Cookies.Append("FavoriteColor", color);
            return RedirectToAction("DisplayFavoriteColor");
        }

        public IActionResult DisplayFavoriteColor()
        {
            ViewBag.FavoriteColor = HttpContext.Request.Cookies["FavoriteColor"] ?? "No color selected";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
