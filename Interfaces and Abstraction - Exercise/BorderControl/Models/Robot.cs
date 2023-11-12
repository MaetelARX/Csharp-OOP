using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models
{
    public class Robot : IRobot
    {
        public string RobotPrint(string input, string test)
        {
            int count = test.Length;
            StringBuilder stringBuilder = new StringBuilder();

            string text = "";
            for (int i = 1; i <= count; i++)
            {
                text += input[input.Length - i];
            }
            if (string.Join("", text.Reverse()) == test)
            {
                stringBuilder.Append(input);
            }
            return $"{stringBuilder}";
        }
    }
}
