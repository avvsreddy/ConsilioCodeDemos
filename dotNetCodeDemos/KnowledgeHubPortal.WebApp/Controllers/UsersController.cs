using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeHubPortal.WebApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;

        public UsersController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            // get all registered users and display
            var usersList = userManager.Users.ToList();
            return View(usersList);
        }
    }
}
