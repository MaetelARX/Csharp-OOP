using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.AnimalModels
{
    public abstract class Bird : Animal
    {
        private double wingsize;

        public double WingSize
        {
            get { return wingsize; }
            set { wingsize = value; }
        }

        protected Bird(string name, double weight, double wingsize) : base(name, weight)
        {
            WingSize = wingsize;
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
