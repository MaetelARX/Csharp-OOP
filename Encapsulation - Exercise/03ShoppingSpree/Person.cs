using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private readonly List<Product> bag;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }

        public double Money
        {
            get
            {
                return money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }


        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public IReadOnlyCollection<Product> Bag => bag.AsReadOnly();
        public string BoughtProduct(Product product)
        {
            bool canBuy = Money >= product.Money;
            if (canBuy)
            {
                Money -= product.Money;
                bag.Add(product);
                return $"{Name} bought {product.Name}";
            }
            return $"{Name} can't afford {product.Name}";
        }
    }
}
