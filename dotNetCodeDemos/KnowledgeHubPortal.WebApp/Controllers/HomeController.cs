using KnowledgeHubPortal.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KnowledgeHubPortal.WebApp.Controllers
{
    public class HomeController : Controller
    {
      
        // domain/
        public IActionResult Index()
        {
            return View();
        }

        // domain/home/privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // domain/home/hello
        public IActionResult Hello()
        {
            return View();
        }

      
    }
}
