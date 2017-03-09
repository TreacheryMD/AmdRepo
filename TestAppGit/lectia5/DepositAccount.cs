using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class DepositAccount : BankAccount
    {
        double _depIntRate;
        public DepositAccount(CurrentAccount curentAcc, decimal balance, double depositInterestRate) :
            base(curentAcc.Owner, balance, curentAcc.AccountNumber.Substring(0, curentAcc.AccountNumber.Length - 2) + "DEP")
        {
            _depIntRate = depositInterestRate;
        }

        public override void ShowAccountInfo()
        {
            Console.WriteLine("Deposit Account:");
            base.ShowAccountInfo();
        }

        public void CalcDepAftMonths(int numbOfMonths)
        {
            for (int i = 0; i < numbOfMonths; i++)
            {
                this.Balance += (this.Balance * (decimal)this._depIntRate /100)/12;
            }
            
        }

        public void Transfer(BankAccount targetAcc, decimal ammount)
        {
            throw new NotImplementedException();
        }
    }
}
