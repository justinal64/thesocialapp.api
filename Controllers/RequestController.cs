using System.Collections.Generic;
using thechurchapp.api.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace thesocialapp.api.Controllers
{
    [Route("api/[controller]")]
    public class RequestController : Controller
    {
        protected PostsRepository _repository;
        public RequestController()
        {
            _repository = new PostsRepository();
        }

        // GET api/get
        [HttpGet]
        public List<PostModel> Get(string jsonQuery = "")
        {
            if (jsonQuery == "") return  _repository.SelectAll();

            return _repository.Filter(jsonQuery);

        }
        
        // POST api/request
        [HttpPost]
        public PostModel Post([FromBody]PostModel postModel, string id = "")
        {
            if (id == "") return _repository.InsertPost(postModel);
            return _repository.UpdatePost(id, postModel);
        }
        
        // PUT api/request
        [HttpPut]
        public PostModel Put([FromBody]PostModel postModel, string id = "")
        {
            if (id == "") return _repository.InsertPost(postModel);
            return _repository.UpdatePost(id, postModel);
        }
        
        // Delete api/request
        [HttpDelete]
        public PostModel Delete([FromBody]PostModel postModel, string id = "")
        {
            if (id == "") return _repository.InsertPost(postModel);
            return _repository.UpdatePost(id, postModel);
        }
    }
}
