using MyModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Accounts;

namespace MyModel.Testing_proxy
{
    public class ProxyConvertor : ICursManager
    {
        public decimal CurrencyConvert(CurrencyTypes currency1, CurrencyTypes currency2, decimal ammount)
        {
            Exchange exchange = new Exchange();

            if (!Exchange.ExchangeToMDL.Any()) throw new Exception("Exchange rate was not loaded");
            if (currency1 == currency2) return ammount;

            return Exchange.ExchangeToMDL[currency1.ToString()] * ammount / Exchange.ExchangeToMDL[currency2.ToString()];
        }
    }
}
