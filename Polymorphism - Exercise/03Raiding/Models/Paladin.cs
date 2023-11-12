using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        private const int power = 100;

        public Paladin(string name) : base(name, power)
        {
            this.Power = power;
        }
        public override string CastAbility()
        {
            Sum += Power;
            return $"Paladin - {Name} healed for {Power}";
        }
    }
}
