using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public string FavoriteFood { get; set; }

        public Animal(string name, string favoriteFood)
        {
            Name = name;
            FavoriteFood = favoriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my favourite food is {FavoriteFood}";
        }
    }
}
