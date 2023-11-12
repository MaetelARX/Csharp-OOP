using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.AnimalModels
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double WingSize) : base(name, weight, WingSize)
        {
        }
        public override string Sound()
        {
            return $"Hoot Hoot";
        }
    }
}
