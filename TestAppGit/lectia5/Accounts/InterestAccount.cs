using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class InterestAccount : BankAccount, ITransferRecive
    {
        double _intRate;
        decimal _mPay;
        public InterestAccount(CurrentAccount curentAcc, decimal balance, double interestRate, decimal monthlyPaymant, DateTime openDate, string currency) :
        base(curentAcc.Client, balance, curentAcc.AccNum.Substring(0, curentAcc.AccNum.Length - 2) + "INT", openDate, currency)
        {
            _intRate = interestRate;
            _mPay = monthlyPaymant;
        }

        public override void ShowAccountInfo()
        {
            Console.WriteLine("Interest Account:");
            base.ShowAccountInfo();
        }

        public void CalculateRateAfterMonths(int numberOfMonths, CreditAccount credAccBal, CurrentAccount curAccBal)
        {
            if (this.AccNum.Substring(0, AccNum.Length - 3) == credAccBal.AccNum.Substring(0, credAccBal.AccNum.Length - 4)
                && (this.AccNum.Substring(0, AccNum.Length - 3) == curAccBal.AccNum.Substring(0, curAccBal.AccNum.Length - 2)))
            {
                for (int i = 0; i < numberOfMonths; i++)
                {
                    this.Balance = credAccBal.Balance * (decimal)_intRate / 12;
                    credAccBal.Balance -= _mPay;
                    curAccBal.Balance -= _mPay;
                }
            }
            else
            {
                Console.WriteLine("Wrong CreditAccount! This owener doesn't have Credit");
            }
        }

        public void Recive(decimal ammount)
        {
            this.Balance += ammount;
        }
    }
}
