using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class InterestAccount : BankAccount
    {
        public InterestAccount(CurrentAccount accOwner, decimal balance, CurrentAccount accNumber) : base(accOwner.Owner, balance, accNumber.AccountNumber)
        {

        }

        public override void ShowAccountInfo()
        {
            Console.WriteLine("Interest Account:");
            base.ShowAccountInfo();
        }
    }
}
