using KnowledgeHubPortal.Domain.Entities;
using KnowledgeHubPortal.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeHubPortal.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private KHPDbContext db = new KHPDbContext(); // DIP

        public void Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Categories.Remove(db.Categories.Find(id));
            db.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return db.Categories.Find(id);  
        }

        public void Update(Category category)
        {
            db.Categories.Update(category);
            db.SaveChanges();
        }
    }
}
