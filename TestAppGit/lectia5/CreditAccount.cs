using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class CreditAccount : BankAccount, ITransferRecive
    {
        public CreditAccount(CurrentAccount curentAcc, decimal newCreditAmmout) :
            base(curentAcc.Owner, newCreditAmmout, curentAcc.AccountNumber.Substring(0, curentAcc.AccountNumber.Length - 2) + "CRED")
        {

        }

        public void Recive(decimal ammount)
        {
            this.Balance -= ammount;
        }

        public override void ShowAccountInfo()
        {
            Console.WriteLine("Credit account:");
            base.ShowAccountInfo();
        }


    }
}
