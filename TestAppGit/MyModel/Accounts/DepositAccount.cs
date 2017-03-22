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
        private readonly double _depIntRate;
        public DepositAccount(string client,string accNum, decimal balance, double depositInterestRate, DateTime openDate, string currency) :
            base(client, balance, accNum.Substring(0, accNum.Length - 2) + "DEP", openDate, currency)
        {
            _depIntRate = depositInterestRate;
        }

        public DepositAccount(string line) : base(line)
        {
            var test = line.Split('|').Where(w => w.Contains("Interest Rate:")).Select(s => s.Replace("Interest Rate:", "").Replace("Type: DepositAccount","").Replace(" ","")).FirstOrDefault();
            _depIntRate = Convert.ToDouble(test);
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
