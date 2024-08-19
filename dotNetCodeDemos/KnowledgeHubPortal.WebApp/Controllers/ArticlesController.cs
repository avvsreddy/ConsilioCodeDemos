using KnowledgeHubPortal.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KnowledgeHubPortal.WebApp.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly IArticlesRepository aRepo;
        private readonly ICategoryRepository cRepo;

        public ArticlesController(IArticlesRepository aRepo, ICategoryRepository cRepo)
        {
            this.aRepo = aRepo;
            this.cRepo = cRepo;
        }


        // browse articles
        public IActionResult Index(int cid=0)
        {

            // fetch all approved articles for browse
            var articlesToBrowse = aRepo.GetArticlesForBrowse(cid);
            // fetch all categories
            var categories = from cat in cRepo.GetAll()
                             select new SelectListItem 
                             {
                                 Text= cat.Name, Value=cat.CategoryId.ToString()
                             };

            ViewBag.Categories = categories;
            //ViewData["Categories"] = categories;


            return View(articlesToBrowse);
        }
    }
}
