using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class Druid : BaseHero
    {
        private int power = 80;
        public Druid(string name) : base(name)
        {
        }
        
        public override string Name { get; set; }

        public override int Power
        {
            get
            {
                return this.power;
            }
            set => value = power;
        }
    }

    
}
