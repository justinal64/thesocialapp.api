using System.Collections.Generic;
using thechurchapp.api.Repository;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Blog.DotNetCoreMongoDb.Controllers
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
            if (jsonQuery == "") return _repository.SelectAll();
            Console.WriteLine("Test");

            return _repository.Filter(jsonQuery);

        }

        public PostModel Post(PostModel postModel, string id = "")
        {
            if (id == "") return _repository.InsertPost(postModel);
            return _repository.UpdatePost(id, postModel);
        }
    }
}
