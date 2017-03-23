using MyModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Clients;

namespace MyModel.Accounts
{
    class DepositAccount : BankAccount, ITransferRecive
    {
        private readonly double _depIntRate;
        public DepositAccount(string fiscalCode,string accNum, decimal balance, double depositInterestRate, DateTime openDate, CurrencyTypes currency) :
            base(fiscalCode, balance, accNum + "DEP", openDate, currency)
        {
            if (depositInterestRate <= 0) throw new Exception($"Invalid field:{nameof(depositInterestRate)}<=0");
            _depIntRate = depositInterestRate;
        }
        public DepositAccount(string line) : base(line)
        {
            //var test = line.Split(';').Where(w => w.Contains("Interest Rate:")).Select(s => s.Replace("Interest Rate:", "").Replace("Type: DepositAccount","").Replace(" ","")).FirstOrDefault();
            //_depIntRate = Convert.ToDouble(test);
        }
        public DepositAccount(){}
        public override void ShowAccountInfo() => Console.WriteLine(ToString());

        public void CalcDepAftMonths(int numbOfMonths)
        {
            for (int i = 0; i < numbOfMonths; i++) InBalance(Balance * (decimal) _depIntRate / 100 / 12);
        }
        public void Recive(decimal ammount) => InBalance(ammount);

        public override string ToString() => base.ToString() + $";{_depIntRate}";
    }
}
