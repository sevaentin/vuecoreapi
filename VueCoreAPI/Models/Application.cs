using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VueCoreAPI.Models
{
    public class Application
    {
        public string email { get; set; }
        public string passportNumber { get; set; }
        public int country { get; set; }
        public int question { get; set; }
        public string securityAnswer { get; set; }
    }
}
