using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class Rogue : BaseHero
    {
        private int power = 80;
        public Rogue(string name) : base(name)
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
