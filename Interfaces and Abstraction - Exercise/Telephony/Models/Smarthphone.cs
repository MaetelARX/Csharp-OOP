using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Models.Interfaces;

namespace Telephony.Models
{
    public class Smarthphone : IBrowse, ICall
    {
        public string Browse(string url)
        {
            if (!validateUrl(url))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {url}!";
        }
        private bool validateUrl(string url)
        {
            return url.All(c => !char.IsDigit(c));
        }

        public string Call(string phoneNumber)
        {
            if (!Validate(phoneNumber))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Calling... {phoneNumber}";
        }
        private bool Validate(string phoneNumber)
        {
            return phoneNumber.All(c => char.IsDigit(c));
        }
    }
}
