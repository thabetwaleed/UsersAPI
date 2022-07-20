using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using UsersAPI.Model;
using UsersAPI.Repos;

namespace UsersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return UserRepos.GetALL();
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            var _user = UserRepos.Get(id);
            if (_user == null)
                return NotFound();
            return _user;
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            UserRepos.Add(user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var _user = UserRepos.Get(id);
            if (_user == null)
                return NotFound();
            UserRepos.Delete(id);
            return Ok();
        }

        [HttpPut]
        public ActionResult Update(User user, int id)
        {
            UserRepos.Update(user, id);
            return Ok();

        }


    }
}
