using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.AnimalModels
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double WingSize) : base(name, weight, WingSize)
        {
        }
        public override string Sound()
        {
            return $"Cluck";
        }
    }
}
