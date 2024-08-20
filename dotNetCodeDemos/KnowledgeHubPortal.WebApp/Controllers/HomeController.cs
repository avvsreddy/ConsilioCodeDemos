using KnowledgeHubPortal.WebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KnowledgeHubPortal.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;

        public HomeController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }
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
            var users = userManager.Users.ToList();
            return View(users);
        }
     
    }
}
