using FoodShortage.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Models
{
    public class Citizen : Person, ICitizen
    {
        public Citizen(string name, int age, string group) : base(name, age)
        {
            Group = group;
        }

        public string Group { get; protected set; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
