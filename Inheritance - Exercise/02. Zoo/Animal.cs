﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }

        public virtual string Name { get; set; }
    }
}