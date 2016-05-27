using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCCTest
{
    class CreditCardInfo
    {

        public CreditCardType AcceptedCreditCardTypes { get; set; }

        public CreditCardInfo()
        {
        }

        public bool ValidateCreditCard(string cardNumber)
        {
            return false;
        }

        public CreditCardType GetCreditCardType(string cardNumber)
        {
            return CreditCardType.Unknown;
        }

    }
}
