using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.AnimalModels
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, double weight, string livingregion) : base(name, weight)
        {
            LivingRegion = livingregion;
        }
        private string livingregion;

        public string LivingRegion
        {
            get { return livingregion; }
            set { livingregion = value; }
        }

    }
}
