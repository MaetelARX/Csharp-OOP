﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Models.Interfaces
{
    public interface IPerson : IBuyer
    {
        string Name { get; }
        int Age { get; }
    }
}
