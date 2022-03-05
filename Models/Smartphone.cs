using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : IBrawsable, ICallable
    {
        public string Browse(string site)
        {
            if (site.Any(x => char.IsDigit(x)))
            {
                return "Invalid URL!";
            }          
            return $"Browsing: {site}!";
        }

        public string Call(string number)
        {
            if (!number.All(char.IsDigit))
            {
                return "Invalid number!";
            }
            else if (number.Length == 7)
            {
                return $"Dialing... {number}";
            }            
            return $"Calling... {number}";
            
        }
    }
}
