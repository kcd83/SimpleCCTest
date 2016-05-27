using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCCTest
{
    enum CreditCardType
    {
        None = 0,
        Visa = 0x01,
        MasterCard = 0x02,
        Amex = 0x04,
        Unknown = 0x08,
        Any = 0xFF
    }
}
