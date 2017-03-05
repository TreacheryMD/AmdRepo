using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class DepositAccount : BankAccount
    {
        public DepositAccount(CurrentAccount accOwner, decimal balance, CurrentAccount accNumb) : base(accOwner.Owner, balance, accNumb.AccountNumber+"DEP")
        {

        }

        public override void ShowAccountInfo()
        {
            Console.WriteLine("Deposit Account:");
            base.ShowAccountInfo();
        }
    }
}
