using System.Text.RegularExpressions;

namespace SimpleCCTest.Validators
{
    class VisaValidator : CreditCardTypeValidator
    {
        private static readonly Regex matchCheck = new Regex("^[40|41|42]", RegexOptions.Compiled);
        private const string shortNumberPrefix = "42";

        public override CreditCardType Type { get { return CreditCardType.Visa; } }

        public override bool IsMatch(string cardNumber)
        {
            if (!IsACreditCardNumber(cardNumber))
                return false;

            return matchCheck.IsMatch(cardNumber);
        }

        public override bool IsValid(string cardNumber)
        {
            if (IsMatch(cardNumber))
            {
                if(cardNumber.StartsWith(shortNumberPrefix))
                    return cardNumber.Length == 13;
                return cardNumber.Length == 16;
            }
            return false;
        }
    }
}
