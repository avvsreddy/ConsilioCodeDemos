using KnowledgeHubPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeHubPortal.Domain.Repository
{
    public interface ICategoryRepository
    {
        void Create(Category category);
        void Update(Category category); 

        List<Category> GetAll();
        Task<List<Category>> GetAllAsync();
        Category GetById(int id);

        void Delete(int id);
    }
}
