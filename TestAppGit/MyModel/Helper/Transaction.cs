using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Accounts;

namespace MyModel
{
    public class Transaction
    {
        private BankAccount _source;
        private BankAccount _target;
        private decimal _ammount;
        private CurrencyTypes _currencyType;
        private DateTime _date;

        public Transaction(BankAccount source, BankAccount target, decimal ammount)
        {
            _source = source;
            _target = target;
            _ammount = ammount;
            _date = DateTime.Now;
            _currencyType = source.Currency;
        }
    }
}
