using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebRestfulAPI.Data;
using WebRestfulAPI.Model;
namespace WebRestfulAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private ArticleApiContext _context1;
        private IRepository _repository;
        public ArticleController(IRepository repository, ArticleApiContext context)
        {
            _context1 = context;
            _repository = repository;
        }

        //Edit
        [HttpPost]
        public JsonResult Post(Article article)
        {
            Guid id = _repository.Create(article);
            if (id == Guid.Empty)
            {
                return new JsonResult(NotFound());
            }
            return new JsonResult(Ok(article));
           
        }

        //Edit
        [HttpPut]
        public JsonResult Put(Article article)
        {
            bool articleUpdate = _repository.Update(article);
            if(!articleUpdate)
            {
                return new JsonResult(NotFound());
            }
            return new JsonResult(Ok(article));
          
        }
        //Get
        [HttpGet]
        public JsonResult Get(Guid Id)
        {
          var articleInDb = _repository.Get(Id);
          if (articleInDb == null)
          {
              return new JsonResult(NotFound());
          }
          return new JsonResult(Ok(articleInDb));
          
        }

        //Delete
        [HttpDelete]
        public JsonResult Delete(Guid Id)
        {
            bool result = _repository.Delete(Id);
            if(!result)
            {
                return new JsonResult(NotFound());
            }
            return new JsonResult(Ok(NoContent()));            
        }

        //GetAll
        [HttpGet("/GetAll")]
        public JsonResult GetAll()
        {
            var articleInDb = _context1.Articles.ToList();
            return new JsonResult(Ok(articleInDb));
        }
    }
}
