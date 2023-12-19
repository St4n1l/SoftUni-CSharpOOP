using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Cake : Dessert
    {
        private const double Cake_Grams = 250;
        private const double Cake_Calories = 1000;
        private const decimal Cake_Price = 5;

        public Cake(string name) : base(name, Cake_Price, Cake_Grams, Cake_Calories)
        {

        }
    }
}
