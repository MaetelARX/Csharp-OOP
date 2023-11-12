using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.AnimalModels
{
    public abstract class Animal
    {
		public Animal(string name, double weight) 
		{
			Name = name;
			Weight = weight;
		}
		private string name;
		private double weight;
		private int foodeaten;

		public int FoodEaten
		{
			get { return foodeaten; }
			set { foodeaten = value; }
		}


		public double Weight
		{
			get { return weight; }
			set { weight = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

        public virtual string Sound()
        {
			return default;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
