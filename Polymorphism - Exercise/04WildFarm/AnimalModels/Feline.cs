using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.AnimalModels
{
    public abstract class Feline : Mammal
    {

        private string breed;

        protected Feline(string name, double weight, string livingregion, string breed) : base(name, weight, livingregion)
        {
            Breed = breed;
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
