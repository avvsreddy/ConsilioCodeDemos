using KnowledgeHubPortal.Data;
using KnowledgeHubPortal.Domain.Entities;
using KnowledgeHubPortal.Domain.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeHubPortal.WebApp.Controllers
{
    public class CategoriesController : Controller
    {
        // .../categories/index
        public IActionResult Index()
        {
            
            // fetch the categories list from datalayer
            ICategoryRepository repo = new CategoryRepository(); // BAD - DIP
            List<Category> categories = repo.GetAll();
            
            // send the list of categories to view
            return View(categories);
        }

        public IActionResult Add() 
        { 
            return View();
        }

        public IActionResult Save(Category category) 
        {
            // server side validation
            if (!ModelState.IsValid) 
            {
                return View("Add");
            }

            ICategoryRepository repo = new CategoryRepository(); // BAD - DIP
            repo.Create(category);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            // get the category object by id
            ICategoryRepository repo = new CategoryRepository(); // BAD - DIP
            Category categoryToEdit = repo.GetById(id);
            return View(categoryToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            // server side validation
            if (!ModelState.IsValid)
            {
                return View();
            }
            ICategoryRepository repo = new CategoryRepository(); // BAD - DIP
           
            repo.Update(category);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id) 
        {
            ICategoryRepository repo = new CategoryRepository();
            repo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
