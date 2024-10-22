﻿using KnowledgeHubPortal.Domain.Entities;
using KnowledgeHubPortal.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeHubPortal.Data
{
    public class ArticlesRepository : IArticlesRepository
    {
        private KHPDbContext db = new KHPDbContext();
        public void Approve(List<int> ids)
        {
            foreach (int id in ids) 
            {
                var articleToApprove = db.Articles.Find(id);
                if (articleToApprove != null) 
                { 
                    articleToApprove.IsApproved = true;
                }
            }
            db.SaveChanges();
        }

        public List<Article> GetArticlesForBrowse(int cid = 0)
        {
            if(cid == 0)
                return db.Articles.Where(a => a.IsApproved).ToList();
            else
                return db.Articles.Where(a => a.IsApproved && a.CategoryId == cid).ToList();
        }

        public List<Article> GetArticlesForReview(int cid = 0)
        {
            if (cid == 0)
                return db.Articles.Include("Category").Where(a => !a.IsApproved).ToList();
            else
                return db.Articles.Include("Category").Where(a => !a.IsApproved && a.CategoryId == cid).ToList();
        }

        public void Reject(List<int> ids)
        {
            foreach (int id in ids)
            {
                var articleToReject = db.Articles.Find(id);
                if (articleToReject != null)
                {
                    db.Articles.Remove(articleToReject);
                }
            }
            db.SaveChanges();
        }

        public void Submit(Article article)
        {
            db.Articles.Add(article);
            db.SaveChanges();
        }
    }
}
