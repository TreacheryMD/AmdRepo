using NUnitTesting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitTesting.Accounts;
using NUnitTesting.Helper;

namespace NUnitTesting.Testing_proxy
{
    public class ProxyConvertor : ICursManager
    {
        public decimal CurrencyConvert(CurrencyTypes currency1, CurrencyTypes currency2, decimal ammount)
        {
            Exchange exchange = new Exchange();
            

            if (!exchange.ExchangeToMDL.Any()) throw new Exception("Exchange rate was not loaded");
            if (currency1 == currency2) return ammount;

            return exchange.ExchangeToMDL[currency1.ToString()] * ammount / exchange.ExchangeToMDL[currency2.ToString()];
        }
    }
}
