using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero
    {
        public BaseHero(string name)
        {
            Name = name;
        }
        public virtual string Name { get; set; }
        public virtual int  Power { get; set; }

        public virtual string CastAbility()
        {
            if (this.GetType().Name == "Druid" || this.GetType().Name == "Paladin")
            {
                return $"{this.GetType().Name} - {Name} healed for {Power}";
            }
            else
            {
                return $"{this.GetType().Name} - {Name} hit for {Power} damage";
            }
        }
    }
}
