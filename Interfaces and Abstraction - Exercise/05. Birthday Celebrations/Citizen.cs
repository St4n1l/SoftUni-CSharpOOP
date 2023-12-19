using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace BirthdayCelebrations
{
    class Citizen : AbstractClassBirthdays
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdays = birthdate;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}
