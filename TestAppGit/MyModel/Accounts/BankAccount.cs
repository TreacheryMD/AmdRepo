using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Clients;
using MyModel.Helper;

namespace MyModel.Accounts
{
    public enum CurrencyTypes { USD, EUR, RUB, RON, MDL }

    public abstract class BankAccount
    {
        public string AccNum { get; protected set; }
        public decimal Balance { get; protected set;}
        public DateTime OpenDate { get;  }
        public CurrencyTypes Currency { get; }
        public string FiscalCode { get; }

        protected BankAccount()
        {
            FiscalCode = "00000000000";
            AccNum = "000000000000";
            Currency = CurrencyTypes.MDL;
        }
        protected BankAccount(string fiscalCode, decimal balance, string accNum, DateTime openDate, CurrencyTypes currency)
        {
            if (balance <0 ) throw new Exception($"{nameof(balance)} can't be less than 0");
            if (string.IsNullOrWhiteSpace(accNum)) throw new ArgumentNullException(nameof(accNum));
            if (openDate < DateTime.Now.AddYears(-125)) throw new Exception($"Invalid field:{nameof(openDate)} < {DateTime.Now.AddYears(-125).ToShortDateString()}");

            FiscalCode = fiscalCode;
            AccNum = accNum;
            Balance = balance;
            OpenDate = openDate;
            Currency = currency;
        }

        protected BankAccount(string line)
        {
            var l = line.Split(';');
            FiscalCode = l[0];
            AccNum = l[1];
            Balance = Convert.ToDecimal(l[2]);
            OpenDate = DateTime.Parse(l[3]);
            Currency = (CurrencyTypes) Enum.Parse(typeof(CurrencyTypes), l[4]); 
        }

        public virtual void ShowAccountInfo() => Console.Write(ToString());
        public static void ShowAccountInfo(IEnumerable<BankAccount> yourEnum, bool showSorted = false, bool ascending = false)
        {
            if (showSorted) yourEnum = ascending ? yourEnum.OrderBy(o => o.Balance) : yourEnum.OrderByDescending(o => o.Balance);
            foreach (var item in yourEnum) item.ShowAccountInfo();
        }
        public virtual void InBalance(decimal bal) => Balance += bal;
        public virtual void OutBalance(decimal bal) => Balance -= bal;
        public override string ToString() => $"{FiscalCode};{AccNum};{Balance};{OpenDate.ToShortDateString()};{Currency}";
    }
}
