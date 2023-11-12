using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.AnimalModels
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingregion, string breed) : base(name, weight, livingregion, breed)
        {
        }
        public override string Sound()
        {
            return $"ROAR!!!";
        }
    }
}
