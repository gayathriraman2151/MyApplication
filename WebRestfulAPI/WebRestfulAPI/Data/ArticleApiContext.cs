
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using WebRestfulAPI.Model;

namespace WebRestfulAPI.Data
{
    public class ArticleApiContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public ArticleApiContext(DbContextOptions<ArticleApiContext> options) : base(options) 
        { 
        }
    }
}
