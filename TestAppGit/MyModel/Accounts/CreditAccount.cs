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
        DateTime _reimbursement;

        public CreditAccount(string client,string accNum, decimal newCreditAmmout, DateTime openDate, string currency, DateTime reimbursementDate) :
            base(client, newCreditAmmout, accNum.Substring(0, accNum.Length - 2) + "CRED", openDate, currency)
        {
            _reimbursement = reimbursementDate;
        }

        public CreditAccount(string line) : base(line)
        {
            var l = line.Split(';');
            var test = DateTime.Parse(l.Last().Replace("Reimbursement:", "").Replace("Type: CreditAccount", "").Replace(" ", ""));
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
        public override string ToString()
        {
            return base.ToString() + $" ; Reimbursement:{_reimbursement.ToShortDateString()}";
        }

    }
}
