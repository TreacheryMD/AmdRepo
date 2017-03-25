using MyModel.Helper;
using MyModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Clients;

namespace MyModel.Accounts
{
    class CurrentAccount : BankAccount
    {
        public bool Restricted { get; set; }
        public CurrentAccount(string fiscalCode, decimal balance, string accNum, DateTime openDate, CurrencyTypes currency, bool restricted = false) 
            : base(fiscalCode, balance, accNum + "CR", openDate, currency)
        {
            Restricted = restricted;
        }
        public CurrentAccount(string line) : base(line)
        {
           var l = line.Split(';');
           Restricted = l[5].Contains("True");
        }
        public CurrentAccount()
        {
            AccNum+="CR";
        }
        public override void ShowAccountInfo() => Console.WriteLine(ToString());
        public void CashIn(decimal cashInAmmout)
        {
            if (cashInAmmout <= 0) throw new Exception("You can't Cash In nothing to your current account");
            InBalance(cashInAmmout);
        }
        public void CashOut(decimal cashOutAmmount)
        {
            if (Restricted) throw new AccountIsRestrictedException();
            if (cashOutAmmount <= 0) throw new Exception("You can't Cash Out with negative ammount");

            OutBalance(cashOutAmmount); 
        }
        public override void Freeze()
        {
            Restricted = true;
        }


        public override string ToString() => base.ToString()+ $";{Restricted}";
    }
}
