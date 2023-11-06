using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Topping
    {
        private const double BaseCaloriesPerGram = 2;
        Dictionary<string, double> TypeOfToppings;

        private string name;
        private double weight;

        public Topping(string name, double weight) 
        {
            TypeOfToppings = new Dictionary<string, double> { { "meat", 1.2 }, { "veggies", 0.8 }, { "cheese", 1.1 }, { "sauce", 0.9 } };
            Name = name;
            Weight = weight;

        }

        public string Name
        {
            get => name;
            private set
            {
                if (!TypeOfToppings.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                name = value.ToLower();
            }
        }
        public double Weight
        {
            get => weight;
            private set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentException($"{Name} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }
        public double Calories
        {
            get
            {
                double topping = TypeOfToppings[Name];
                return weight * topping * BaseCaloriesPerGram;
            }
        }
    }
}
