using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Raiding
{
    class Warrior : BaseHero
    {
        private int power = 100;
        public Warrior(string name) : base(name)
        {
        }

        public override string Name { get; set; }

        public override int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                value = power;
            }
        }
    }
}
