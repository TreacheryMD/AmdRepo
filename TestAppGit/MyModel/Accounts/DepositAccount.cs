using MyModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModel.Accounts
{
    class DepositAccount : BankAccount, ITransferRecive
    {
        double _depIntRate;
        public DepositAccount(CurrentAccount curentAcc, decimal balance, double depositInterestRate, DateTime openDate, string currency) :
            base(curentAcc.Client, balance, curentAcc.AccNum.Substring(0, curentAcc.AccNum.Length - 2) + "DEP", openDate, currency)
        {
            _depIntRate = depositInterestRate;
        }

        public override void ShowAccountInfo()
        {
            Console.WriteLine(this.ToString());
        }

        public void CalcDepAftMonths(int numbOfMonths)
        {
            for (int i = 0; i < numbOfMonths; i++)
            {
                this.InBalance((this.Balance * (decimal)this._depIntRate / 100) / 12);
            }
        }
        public void Recive(decimal ammount)
        {
            this.InBalance(ammount);
        }

        public override string ToString()
        {
            return base.ToString() + $" | Interest Rate: {_depIntRate}";
        }
    }
}
