using FoodShortage.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Models
{
    public class Rebel : Person, IPerson
    {
        public string Id { get; }
        public string Birthplace { get; }
        public Rebel(string name, int age,string id, string birthplace) : base(name, age)
        {
            Id = id;
            Birthplace = birthplace;
        }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
