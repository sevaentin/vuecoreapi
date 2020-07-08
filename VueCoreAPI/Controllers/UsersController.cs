using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VueCoreAPI.Controllers
{
    [EnableCors("AllowAnyOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
       
        [HttpGet]
        public IEnumerable<User> Get()
        {
            List<User> users = new List<User>();
            users.Add(new User { id = 1, email = "Sincere@april.biz", name = "Leanne Graham", username = "Bret" });

            return users.ToArray();
        }
    }
}
