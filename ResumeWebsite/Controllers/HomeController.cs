using Microsoft.AspNetCore.Mvc;
using ResumeWebsite.Models;
using System.Diagnostics;

namespace ResumeWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ActivePage = "Index";
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.ActivePage = "Contact";
            return View();
        }

        public IActionResult Resume()
        {
            ViewBag.ActivePage = "Resume";
            return View();
        }

        public IActionResult Projects()
        {
            ViewBag.ActivePage = "Projects";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
