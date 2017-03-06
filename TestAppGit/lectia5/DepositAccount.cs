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
        public DepositAccount(CurrentAccount accOwner, decimal balance, CurrentAccount accNumb, double depositInterestRate) :
            base(accOwner.Owner, balance, accNumb.AccountNumber.Substring(0, accNumb.AccountNumber.Length - 2) + "DEP")
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
                this.Balance = this.Balance + (decimal)this._depIntRate * this.Balance / 12;
            }
            
        }
    }
}
