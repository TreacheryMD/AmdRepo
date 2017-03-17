using MyModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModel.Accounts
{
    class CreditAccount : BankAccount, ITransferRecive
    {
        public CreditAccount(CurrentAccount curentAcc, decimal newCreditAmmout, DateTime openDate, string currency) :
            base(curentAcc.Client, newCreditAmmout, curentAcc.AccNum.Substring(0, curentAcc.AccNum.Length - 2) + "CRED", openDate, currency)
        {

        }

        public void Recive(decimal ammount)
        {
            this.OutBalance(ammount);
        }

        public override void ShowAccountInfo()
        {
            Console.WriteLine("Credit account:");
            base.ShowAccountInfo();
        }


    }
}
