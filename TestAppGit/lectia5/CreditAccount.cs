using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class CreditAccount : BankAccount
    {
        public CreditAccount(CurrentAccount accOwner, decimal newCreditAmmout, CurrentAccount accNumb ) :
            base(accOwner.Owner, newCreditAmmout, accNumb.AccountNumber.Substring(0, accNumb.AccountNumber.Length - 2) + "CRED")
        {

        }

        public override void ShowAccountInfo()
        {
            Console.WriteLine("Credit account:");
            base.ShowAccountInfo();
        }
    }
}
