using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCCTest.Validators
{
    abstract class CreditCardTypeValidator
    {
        protected bool IsACreditCardNumber(string cardNumber)
        {
            // could check if all numbers etc
            return !string.IsNullOrEmpty(cardNumber);
        }

        public abstract CreditCardType Type { get; }

        public abstract bool IsMatch(string cardNumber);

        public abstract bool IsValid(string cardNumber);
    }
}
