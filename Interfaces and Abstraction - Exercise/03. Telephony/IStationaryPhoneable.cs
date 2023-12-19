using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface IStationaryPhoneable
    {
        public string Digits { get; set; }
        public void DialPhone();
    }
}
