using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        public const int power = 80;

        public Druid(string name) : base(name, power)
        {
            this.Power = power;
                    }
        public override string CastAbility()
        {
            Sum += Power;
            return $"Druid - {Name} healed for {Power}";
        }
    }
}
