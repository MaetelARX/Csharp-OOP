using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.AnimalModels
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingregion) : base(name, weight, livingregion)
        {
        }
        public override string Sound()
        {
            return $"Squeak";
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
