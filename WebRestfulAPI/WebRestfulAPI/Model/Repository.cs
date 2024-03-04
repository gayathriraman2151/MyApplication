using System;
using System.Data.Entity;
using WebRestfulAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace WebRestfulAPI.Model
{
    public class Repository : IRepository
    {
        private ArticleApiContext _context;
        public Repository(ArticleApiContext context)
        {
            _context = context;
        }
        public Guid Create(Article article)
        {
            if (article.Id == Guid.Empty)
            {
                _context.Articles.Add(article);

            }
            else
            {
                var articleInDb = _context.Articles.Find(article.Id);
                if (articleInDb == null)
                {
                    return Guid.Empty;
                }
                articleInDb = article;
                _context.Update(articleInDb);
            }
           
            _context.SaveChanges();
            return article.Id;
        }

        public bool Delete(Guid Id)
        {
            var articleInDb = _context.Articles.Find(Id);
            if (articleInDb == null)
            {
                return false;
            }
            _context.Articles.Remove(articleInDb);
            _context.SaveChanges();
            return true;
        }


        public Article? Get(Guid Id)
        {
           var articleInDb = _context.Articles.FirstOrDefault(e => e.Id == Id);
           if (articleInDb == null)
            {
                return null;
            }
           return articleInDb;
        }

        public bool Update(Article articleToUpdate)
        {
            if (articleToUpdate.Id == Guid.Empty)
            {
                return false;

            }
            else
            {
                var articleInDb = _context.Articles.Find(articleToUpdate.Id);
                if (articleInDb == null)
                {
                    return false;
                }
                articleInDb.Title = articleToUpdate.Title;
                articleInDb.Text = articleToUpdate.Text;
                _context.Update(articleInDb);
            }
            _context.SaveChanges();
            return true;
        }
    }
}
