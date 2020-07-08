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
    public class DictionaryController : ControllerBase
    {
        private static List<Dictionaries> _countries = DictionaryService.GetCountries();
        private static List<Dictionaries> _questions = DictionaryService.GetSecurityQuestions();
       

        [HttpGet("countries", Name = "GetCountries")]
        public IEnumerable<Dictionaries> GetCountries()
        {
            return _countries.ToArray();
        }

        [HttpGet("questions", Name = "GetQuestions")]
        public IEnumerable<Dictionaries> GetQuestions()
        {
            return _questions.ToArray();
        }
    }
}
