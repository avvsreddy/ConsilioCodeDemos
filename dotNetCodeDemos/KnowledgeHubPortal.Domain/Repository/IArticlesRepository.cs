using KnowledgeHubPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeHubPortal.Domain.Repository
{
    public interface IArticlesRepository
    {
        void Submit(Article article);
        void Approve(List<int> ids);
        void Reject(List<int> ids);
        List<Article> GetArticlesForReview(int cid=0);
        List<Article> GetArticlesForBrowse(int cid=0);
    }
}
