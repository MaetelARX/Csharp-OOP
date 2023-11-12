﻿using BirthdayCelebreation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebreation.Models
{
    public class Pet : IPet
    {
        public string PetPrint(string input, string test)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (input.Contains(test))
            {
                stringBuilder.Append(input);
            }
            return $"{stringBuilder}";
        }
    }
}
