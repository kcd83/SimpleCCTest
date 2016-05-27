using System;


namespace SimpleCCTest.Validators
{
    class AmexValidator : CreditCardTypeValidator
    {
        public override CreditCardType Type { get { return CreditCardType.Amex; } }

        public override bool IsMatch(string cardNumber)
        {
            if (!IsACreditCardNumber(cardNumber))
                return false;

            return cardNumber.StartsWith("34");
        }

        public override bool IsValid(string cardNumber)
        {
            if(IsMatch(cardNumber))
            {
                return cardNumber.Length == 15;
            }
            return false;
        }
    }
}
