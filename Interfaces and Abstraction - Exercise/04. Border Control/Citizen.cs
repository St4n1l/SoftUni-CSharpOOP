using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace BorderControl2
{
    class Citizen : IIDentifiable
    {
        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
