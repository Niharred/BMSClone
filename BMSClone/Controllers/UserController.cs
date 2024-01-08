using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BMSClone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpPost]
        [Route("/createUser")]
        public bool createUser()
        {

            return true;
        }
    }
}
