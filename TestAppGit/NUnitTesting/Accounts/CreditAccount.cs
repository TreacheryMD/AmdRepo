using NUnitTesting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitTesting.Clients;
using NUnitTesting.Accounts;

namespace NUnitTesting.Accounts
{
    class CreditAccount : BankAccount
    {
        public DateTime Reimbursement { get; }

        public CreditAccount(string fiscalCode,string accNum, decimal newCreditAmmout, DateTime openDate, CurrencyTypes currency, DateTime reimbursementDate) :
            base(fiscalCode, newCreditAmmout, accNum + "CRED", openDate, currency)
        {
            if (reimbursementDate < DateTime.Now) throw new Exception($"Invalid field:{nameof(reimbursementDate)}<{DateTime.Now.ToShortDateString()}");
            Reimbursement = reimbursementDate;
        }
        public CreditAccount(string line) : base(line)
        {
            var l = line.Split(';');
            Reimbursement = DateTime.Parse(l[5]);
        }

        public CreditAccount() 
        {
            Reimbursement = DateTime.Now;
        }

        public override void ShowAccountInfo()
        {
            base.ShowAccountInfo();
            Console.WriteLine();
        }
        public override void InBalance(decimal bal)
        {
            if (Balance - bal < 0) throw new Exception($"You transfer too much in Credit account: {Balance - bal}");
            Balance -= bal;
        }

        public override string ToString() => base.ToString() + $";{Reimbursement.ToShortDateString()}";

        public override void Freeze()
        {
            throw new NotImplementedException();
        }
    }
}
