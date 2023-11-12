using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.AnimalModels;

namespace WildFarm.FoodModels
{
    public abstract class Food
    {
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Food(int qunatity)
        {
            Quantity = qunatity;
        }
    }
}
