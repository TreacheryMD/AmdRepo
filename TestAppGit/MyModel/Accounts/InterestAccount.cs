using MyModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Clients;

namespace MyModel.Accounts
{
    class InterestAccount : BankAccount, ITransferRecive
    {
        public double IntRate { get; }
        public decimal MPay { get; }
        public InterestAccount(string fiscalCode,string accNum, decimal balance, double interestRate, decimal monthlyPaymant, DateTime openDate, CurrencyTypes currency) :
        base(fiscalCode, balance, accNum + "INT", openDate, currency)
        {
            if (interestRate <= 0) throw new Exception($"Invalid field:{nameof(interestRate)}<=0");
            if (monthlyPaymant <= 0) throw new Exception($"Invalid field:{nameof(monthlyPaymant)}<=0");

            IntRate = interestRate;
            MPay = monthlyPaymant;
        }
        public InterestAccount(string line) : base(line)
        {
            //var l = line.Split(';');
            //IntRate = Convert.ToDouble(l[5].Replace("Interest Rate:", "").Replace(" ", ""));
            //MPay = Convert.ToDecimal(l[6].Replace("MonthlyPay:", "").Replace("Type: InterestAccount","").Replace(" ", ""));
        }
        public InterestAccount()
        {
        }

        public override void ShowAccountInfo()
        {
            base.ShowAccountInfo();
            Console.WriteLine();
        }

        //public void CalculateRateAfterMonths(int numberOfMonths, CreditAccount credAccBal, CurrentAccount curAccBal)
        //{
        //    if (this.AccNum.Substring(0, AccNum.Length - 3) == credAccBal.AccNum.Substring(0, credAccBal.AccNum.Length - 4)
        //        && (this.AccNum.Substring(0, AccNum.Length - 3) == curAccBal.AccNum.Substring(0, curAccBal.AccNum.Length - 2)))
        //    {
        //        for (int i = 0; i < numberOfMonths; i++)
        //        {
        //            this.Balance = credAccBal.Balance * (decimal)_intRate / 12;
        //            credAccBal.OutBalance(_mPay);
        //            curAccBal.OutBalance(_mPay);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Wrong CreditAccount! This owener doesn't have Credit");
        //    }
        //}

        public void Recive(decimal ammount) => InBalance(ammount);
        public override string ToString() => base.ToString() + $";{IntRate};{MPay}";
    }
}
