﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryService.Models.Interfaces
{
    public interface IEngineer
    {
        IReadOnlyCollection<IRepair> Repairs { get; }
    }
}
