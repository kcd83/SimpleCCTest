using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCCTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Poor man's tests

            Console.WriteLine("Do you require coffee?");
            bool pass = true;

            // https://www.merchantplus.com/help/logos-test-numbers/
            // MasterCard	5431111111111111
            // Amex	341111111111111
            // Visa (16 digits)	4111111111111111
            // Visa (16 digits)	4012888888881881
            // Visa (13 digits)	4222222222222

            string[] testCases =
            {
                "5431111111111111",
                "341111111111111",
                "4111111111111111",
                "4012888888881881",
                "4222222222222"
            };

            CreditCardInfo fixture = new CreditCardInfo()
            {
                AcceptedCreditCardTypes = CreditCardType.Amex | CreditCardType.Visa
            };

            foreach(string test in testCases)
            {
                Console.WriteLine("Card number {0} is {1}a valid {2} of length {3}", test, fixture.ValidateCreditCard(test) ? "": "not ", fixture.GetCreditCardType(test).ToString(), test.Length);
            }
            Console.ReadLine();
        }
    }
}
