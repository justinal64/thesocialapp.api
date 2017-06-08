using System.Collections.Generic;
using thechurchapp.api.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace thesocialapp.api.Controllers
{
    [Route("api/[controller]")]
    public class PostsController : Controller
    {
        protected PostsRepository _repository;
        public PostsController()
        {
            _repository = new PostsRepository();
        }

        // GET api/posts
        [HttpGet]
        public List<PostModel> Get(string jsonQuery = "")
        {
            if (jsonQuery == "") return  _repository.SelectAll();

            return _repository.Filter(jsonQuery);

        }

        // Post api/posts
        [HttpPost]
        public PostModel Post([FromBody]PostModel postModel, string id = "")
        {
            var test = new PostModel{
                Company = "Test",
                Posts = "This is a test post",
                Username = "Username dahhhh",
                Password = "Well password"
            };
            if (id == "") return _repository.InsertPost(test);
            return _repository.UpdatePost(id, postModel);
        }
    }
}
