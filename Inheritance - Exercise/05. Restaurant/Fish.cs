using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Fish : MainDish
    {
        private const double Fish_Grams = 22;

        public Fish(string name, decimal price) : base(name, price, Fish_Grams)
        {
        }
    }
}
