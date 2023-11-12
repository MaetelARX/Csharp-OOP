using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony.Models
{
    public class Stationaryphone : ICall
    {
        public string Call(string phoneNumber)
        {
            if (!Validate(phoneNumber))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Dialing... {phoneNumber}";
        }
        private bool Validate(string phoneNumber)
        {
            return phoneNumber.All(c => char.IsDigit(c));
        }
    }
}
