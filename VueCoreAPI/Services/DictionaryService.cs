using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using VueCoreAPI.Models;

namespace VueCoreAPI.Services
{
    public class DictionaryService
    {
        public static List<Dictionaries> GetCountries()
        {
            List<Dictionaries> countries = new List<Dictionaries>();
            countries.Add(new Dictionaries { id = 1, code = "usa", name = "USA" });
            countries.Add(new Dictionaries { id = 2, code = "isl", name = "Israel" });
            countries.Add(new Dictionaries { id = 3, code = "fra", name = "France" });
            countries.Add(new Dictionaries { id = 4, code = "ita", name = "Italy" });
            countries.Add(new Dictionaries { id = 5, code = "spa", name = "Spain" });
            countries.Add(new Dictionaries { id = 6, code = "jpn", name = "Japan" });

            return countries;
        }

        public static List<Dictionaries> GetSecurityQuestions()
        {
            List<Dictionaries> countries = new List<Dictionaries>();
            countries.Add(new Dictionaries { id = 1, code = "bcn", name = "In what city/town/village you were  born?" });
            countries.Add(new Dictionaries { id = 2, code = "bhn", name = "what is the name of the hospital you ware born?" });
            countries.Add(new Dictionaries { id = 3, code = "ysn", name = "what is the name of the street you grew up?" });
            countries.Add(new Dictionaries { id = 4, code = "chn", name = "What was your childhood nickname?" });

            return countries;
        }
    }
}
