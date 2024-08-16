using KnowledgeHubPortal.Domain.Entities;
using KnowledgeHubPortal.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeHubPortal.Data
{
    public class MockCategoryRepo : ICategoryRepository
    {
        public void Create(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return new List<Category>() 
            { 
                new Category {CategoryId=111, Name="Test 1", Description="test 1"} ,
                 new Category {CategoryId=222, Name="Test 2", Description="test 2"} ,
                  new Category {CategoryId=333, Name="Test 3", Description="test 3"} ,
            };
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
