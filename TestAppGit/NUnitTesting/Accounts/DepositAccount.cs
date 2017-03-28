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
    class DepositAccount : BankAccount
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
            var l = line.Split(';');
            _depIntRate = Convert.ToDouble(l[5]);
        }

        public DepositAccount()
        {
            _depIntRate = 0.00;
        }
        public override void ShowAccountInfo() => Console.WriteLine(ToString());

        public void CalcDepAftMonths(int numbOfMonths)
        {
            for (int i = 0; i < numbOfMonths; i++) InBalance(Balance * (decimal) _depIntRate / 100 / 12);
        }
       
        public override string ToString() => base.ToString() + $";{_depIntRate}";

        public override void Freeze()
        {
            throw new NotImplementedException();
        }
    }
}
