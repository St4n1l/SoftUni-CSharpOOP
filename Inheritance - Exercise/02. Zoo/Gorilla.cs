﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Gorilla : Mammal
    {
        public Gorilla(string name) : base(name)
        {
            Name = name;
        }

        public override  string Name { get; set; }
    }
}
