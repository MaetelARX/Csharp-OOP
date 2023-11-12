using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class BaseHero : ICast
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public int Sum = 0;

        public BaseHero(string name,int power)
        {
            Name = name;
            Power = power;
        }

        public virtual string CastAbility()
        {
            return default;
        }
    }
}
