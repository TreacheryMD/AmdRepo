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
        public CreditAccount(string client,string accNum, decimal newCreditAmmout, DateTime openDate, string currency) :
            base(client, newCreditAmmout, accNum.Substring(0, accNum.Length - 2) + "CRED", openDate, currency)
        {

        }

        public CreditAccount(string line) : base(line)
        {

        }

        public void Recive(decimal ammount)
        {
            this.OutBalance(ammount);
        }

        public override void ShowAccountInfo()
        {
            
            base.ShowAccountInfo();
            Console.WriteLine();
        }


    }
}
