using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    class Pet : AbstractClassBirthdays
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdays = birthdate;
        }
        public string Name { get; set; }
    }
}
