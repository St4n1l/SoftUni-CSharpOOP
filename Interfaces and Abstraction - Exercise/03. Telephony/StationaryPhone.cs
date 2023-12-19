using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : IStationaryPhoneable
    {

        public string Digits { get; set; }
        public void DialPhone()
        {
            Console.WriteLine($"Dialing... {Digits}");
        }
    }
}
