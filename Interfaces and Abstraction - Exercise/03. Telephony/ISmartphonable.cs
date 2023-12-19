using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ISmartphonable
    {
        public string Digits { get; set; }
        public string Website { get; set; }

        public void CallPhones();
        public void BrowseTheWWW();
    }
}
