using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ISmartphonable
    {
        public string Digits { get; set; }
        public string Website { get; set; }

        public void CallPhones()
        {
            Console.WriteLine($"Calling... {Digits}");
        }

        public void BrowseTheWWW()
        {
            Console.WriteLine($"Browsing: {Website}!");
        }
    }
}
