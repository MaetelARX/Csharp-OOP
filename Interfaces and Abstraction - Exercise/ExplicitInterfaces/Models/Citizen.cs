using ExplicitInterfaces.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaces.Models
{
    public class Citizen : IPerson, IResident
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Country { get; private set; }

        public Citizen(string name) 
        {
            Name = name;
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {Name}";
        }
        string IPerson.GetName()
        {
            return Name;
        }
    }
}
