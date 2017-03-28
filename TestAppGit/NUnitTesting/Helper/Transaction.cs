using System;
using NUnitTesting.Accounts;

namespace NUnitTesting.Helper
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
