using MyModel.Helper;
using MyModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModel.Accounts
{
    class CurrentAccount : BankAccount
    {
        public bool Restricted { get; set; }
        public CurrentAccount(string owner, decimal balance, string accountNumber, DateTime openDate, string currency, bool restricted = false) : base(owner, balance, accountNumber + "CR", openDate, currency)
        {
            Restricted = restricted;
        }

        public CurrentAccount(string line) : base(line)
        {
            Restricted = line.Contains("Restricted:True");
        }

        public CurrentAccount():base()
        {
            AccNum+="CR";
        }

        public override void ShowAccountInfo()
        {
            //Console.WriteLine("Curent account:");
            Console.WriteLine(this.ToString());
            //base.ShowAccountInfo();
            //Console.Write($" | Restricted:{Restricted}");
            //Console.WriteLine();
        }

        public void CashIn(decimal cashInAmmout)
        {
            if (cashInAmmout <= 0)
            {
                throw new Exception("You can't Cash In nothing to your current account");
            }
            this.InBalance(cashInAmmout);
           
        }
        public void CashOut(decimal cashOutAmmount)
        {
            if (Restricted) throw new AccountIsRestrictedException();

            if (cashOutAmmount <= 0)
            {
                throw new Exception("You can't Cash Out with negative ammount");
            }
            this.OutBalance(cashOutAmmount); 
        }
        public void Transfer(ITransferRecive source, decimal ammount)
        {
            if (this.Restricted) throw new AccountIsRestrictedException("Account is restricted");
            source.Recive(ammount);
            this.OutBalance(ammount);
        }

        public override string ToString()
        {
            return base.ToString()+ $" ; Restricted:{Restricted}";
        }
    }
}
