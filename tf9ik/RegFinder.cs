using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace tf9ik
{
    class RegFinder
    {
        //private readonly string regex = "[A-Z0-9a-z \"._%+-+@[A-Za-z0-9.-]+\\.[A-Za-z]{2-64}";
        //private readonly string regexMinLocalPart = "[A-Z0-9a-z \"._%+-]{4,}@[A-Za-z0-9.-}+";
        //private readonly string regexMaxLocalPart = "[A-Z0-9a-z \"._%+-]{65,}@[A-Za-z0-9.-]+";
        //ABTOP IGOREK//
        private static readonly Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        //public static RegexRes[] FindAll(string text)
        //{
        //    var matches = regex.Matches(text);
        //    List <RegexRes> toReturn= new List<RegexRes>();
        //    foreach (Match i in matches)
        //    {
        //        RegexRes res = new RegexRes(i.Index, i.Length, i.Value);
                
        //        toReturn += 
        //    }
            
        //}


        public class RegexRes
        {
            public readonly int start;
            public readonly int length;
            public readonly string email;
            public readonly string line;

            public RegexRes(int start, int length, string email)
            {
                this.start = start;
                this.length = length;
                this.email = email;
                
            }

        }
    }
}
