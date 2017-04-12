using System;

namespace BankAccounts.Accounts
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
