using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VueCoreAPI.Services
{
    public class ApplicationService
    {
        private static Random random = new Random();
        public static string GetAppCode()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
           
            string code1 = new string(Enumerable.Repeat(chars, 4)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            string code2 = new string(Enumerable.Repeat(chars, 4)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            string code3 = new string(Enumerable.Repeat(chars, 4)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            string code = string.Format("{0}-{1}-{2}", code1, code2, code3);
            return code;
        }
    }
}
