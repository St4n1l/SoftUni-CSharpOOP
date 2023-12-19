using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class Paladin : BaseHero
    {
        private int power = 100;
        public Paladin(string name) : base(name)
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
