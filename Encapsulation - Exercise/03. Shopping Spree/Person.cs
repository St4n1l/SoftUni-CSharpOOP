using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ShoppingSpree
{
    class Person
    {
        private string name;
        private double money;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Products = new List<string>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception($"Name cannot be empty");
                }

                name = value;
            }
        }

        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                if (value<0)
                {
                    throw new Exception($"Money cannot be negative");
                }

                money = value;
            }
        }

        public List<string> Products { get; set; }
    }
}
