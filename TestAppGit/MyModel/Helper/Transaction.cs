using System;
using MyModel.Accounts;

namespace MyModel.Helper
{
    public class Transaction
    {
        public virtual int Id { get; set; }
        public virtual BankAccount Source { get; }
        public virtual BankAccount Target { get; }
        public virtual decimal Ammount { get; }
        public virtual CurrencyTypes CurrencyType { get; }
        public virtual DateTime Date { get; }

        public Transaction(BankAccount source, BankAccount target, decimal ammount)
        {
            Source = source;
            Target = target;
            Ammount = ammount;
            Date = DateTime.Now;
            CurrencyType = source.Currency;
        }
    }
}
