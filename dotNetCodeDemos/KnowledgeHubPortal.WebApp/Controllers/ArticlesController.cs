using Humanizer;
using KnowledgeHubPortal.Domain.Entities;
using KnowledgeHubPortal.Domain.Repository;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]
        [Authorize]
        public IActionResult Submit()
        {
            var categories = from cat in cRepo.GetAll()
                             select new SelectListItem
                             {
                                 Text = cat.Name,
                                 Value = cat.CategoryId.ToString()
                             };

            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Submit(Article article)
        {
            // validate
            if (!ModelState.IsValid) 
            {
                return View();
            }
            
            // save

            article.DateSubmited = DateTime.Now;
            article.IsApproved=false;
            if (User.Identity.IsAuthenticated)
                article.SubmitedBy = User.Identity.Name;
            else
                article.SubmitedBy = "Unknown";

            aRepo.Submit(article);

            TempData["Message"] = $"Artile {article.Title} submited successfully for admin review";

            return RedirectToAction("Index");
        }

        [Authorize(Roles ="admin")]
        public IActionResult Review(int cid=0)
        {
            // fetch all new  articles for review
            var articlesToReview = aRepo.GetArticlesForReview(cid);
            // fetch all categories
            var categories = from cat in cRepo.GetAll()
                             select new SelectListItem
                             {
                                 Text = cat.Name,
                                 Value = cat.CategoryId.ToString()
                             };

            

            ViewBag.Categories = categories;

            return View(articlesToReview);
        }
        [Authorize(Roles = "admin")]
        public IActionResult Approve(List<int> articleIds)
        {
            aRepo.Approve(articleIds);
            TempData["Message"] = $"{articleIds.Count} Article/s Approved Successfully";
            return RedirectToAction("Review");
        }
        [Authorize(Roles = "admin")]
        public IActionResult Reject(List<int> articleIds)
        {
            aRepo.Reject(articleIds);
            TempData["Message"] = $"{articleIds.Count} Article/s Rejected Successfully";
            return RedirectToAction("Review");
        }
    }
}
