using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Engine
    {
        private Smartphone smartphone;
        private List<string> phoneNumbers;
        private List<string> urls;
        public Engine() 
        {
            this.smartphone = new Smartphone();
            this.phoneNumbers = new List<string>();
            this.urls = new List<string>(); 
        }

        public void Run() 
        {
            var phoneNumbers = Console.ReadLine().Split().ToList();
            var websites = Console.ReadLine().Split().ToList();

            foreach (var phoneNumber in phoneNumbers)
            {
                Console.WriteLine(smartphone.Call(phoneNumber)); 
            }
            foreach (var site in websites)
            {
                Console.WriteLine(smartphone.Browse(site));
            }
        }
    }
}
