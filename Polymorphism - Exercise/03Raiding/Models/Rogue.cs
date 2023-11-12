using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        private const int power = 80;

        public Rogue(string name) : base(name, power)
        {
            this.Power = power;
        }
        public override string CastAbility()
        {
            Sum += Power;
            return $"Rogue - {Name} hit for {Power} damage";
        }
    }
}
