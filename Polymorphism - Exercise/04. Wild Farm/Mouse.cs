﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight,  livingRegion)
        {
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
