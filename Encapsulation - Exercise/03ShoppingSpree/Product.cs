using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Product
    {
		private string name;
		private double money;

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
				if(string.IsNullOrEmpty(value) || value == " ")
				{
					throw new ArgumentException("Name cannot be empty");
				} 
				name = value;
			}
		}
		public Product(string name, double money)
		{
			Name = name;
			Money = money;
		}
		public override string ToString()
		{
			return Name;
		}
	}
}
