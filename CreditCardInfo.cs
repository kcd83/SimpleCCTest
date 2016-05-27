using SimpleCCTest.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCCTest
{
    class CreditCardInfo
    {

        private CreditCardType _AcceptedCreditCardTypes;

        private List<CreditCardTypeValidator> _Validators;

        /// <summary>
        /// Beware I'm actually a bitflag
        /// </summary>
        public CreditCardType AcceptedCreditCardTypes {
            get { return _AcceptedCreditCardTypes; } // is this really needed?
            set
            {
                _AcceptedCreditCardTypes = value;
                InitialiseValidTypes(value);
            }
        }

        public CreditCardInfo()
        {
        }

        public bool ValidateCreditCard(string cardNumber)
        {
            return _Validators.Any(v => v.IsValid(cardNumber));
        }

        public CreditCardType GetCreditCardType(string cardNumber)
        {
            CreditCardTypeValidator match = _Validators.Where(v => v.IsMatch(cardNumber)).SingleOrDefault();
            if (match != null)
                return match.Type;
            return CreditCardType.Unknown;
        }

        private void InitialiseValidTypes(CreditCardType acceptedCreditCardTypes)
        {
            _Validators = new List<CreditCardTypeValidator>();
            foreach (CreditCardType type in Enum.GetValues(typeof(CreditCardType)))
            {
                if ((type & acceptedCreditCardTypes) != CreditCardType.None) // bitwise check returns type... but we don't want None either
                {
                    CreditCardTypeValidator validator = null;
                    switch (type)
                    {
                        case CreditCardType.None:
                            break;
                        case CreditCardType.Visa:
                            break;
                        case CreditCardType.MasterCard:
                            break;
                        case CreditCardType.Amex:
                            validator = new AmexValidator();
                            break;
                        case CreditCardType.Unknown:
                            break;
                        case CreditCardType.Any:
                            break;
                        default:
                            break;
                    }
                    if (validator != null)
                        _Validators.Add(validator);
                }

            }
        }

    }
}
