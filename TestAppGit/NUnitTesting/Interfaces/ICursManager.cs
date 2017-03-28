using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitTesting.Accounts;

namespace NUnitTesting.Interfaces
{
    public interface ICursManager
    {
        decimal CurrencyConvert(CurrencyTypes currency1, CurrencyTypes currency2, decimal ammount);
    }
}
