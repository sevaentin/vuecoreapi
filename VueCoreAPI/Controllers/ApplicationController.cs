using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VueCoreAPI.Models;
using VueCoreAPI.Services;

namespace VueCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAnyOrigin")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private static List<Application> _apps = new List<Application>();

        [HttpPost("start", Name = "StartApp")]
        public Result StartApp(Application app)
        {
            Result result = new Result();
            _apps.Add(app);
            result.error = 0;
            result.description = ApplicationService.GetAppCode();
            result.date = DateTime.Now.ToString("dd MMMM,yyyy");
            return result;
        }
    }
}
