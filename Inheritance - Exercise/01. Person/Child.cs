using System;
using System.Collections.Generic;
using System.Text;

namespace NotPerson
{
    class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
        }

        public override int Age
        {
            get => base.Age;
            set
            {
                if (Age<=15)
                {
                    base.Age = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
