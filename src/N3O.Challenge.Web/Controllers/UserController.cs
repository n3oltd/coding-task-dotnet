using Microsoft.AspNetCore.Mvc;

namespace N3O.Challenge.Web.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class UserController : Controller {
        [HttpPost]
        public IActionResult CreateUser() {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetUsers() {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetUser() {
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteUser() {
            return Ok();
        }

        [HttpPut]
        public IActionResult PutUser() {
            return Ok();
        }
    }
}