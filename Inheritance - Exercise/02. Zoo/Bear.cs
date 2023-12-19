﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Bear : Mammal
    {
        public Bear(string name) : base(name)
        {
            Name = name;
        }

        public override string Name { get; set; }
    }
}
