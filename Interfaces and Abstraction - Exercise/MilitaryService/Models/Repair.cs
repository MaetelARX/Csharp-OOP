﻿using MilitaryService.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryService.Models
{
    public class Repair : IRepair
    {
        public string PartName { get; private set; }

        public int Hours { get; private set; }

        public Repair(string partName, int hours) 
        {
            PartName = partName;
            Hours = hours;
        }
        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {Hours}";
        }
    }
}
