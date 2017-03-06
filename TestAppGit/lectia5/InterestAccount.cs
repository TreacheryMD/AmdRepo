using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class InterestAccount : BankAccount
    {
        double _intRate;
        decimal _mPay;
        public InterestAccount(CurrentAccount curentAcc, decimal balance,double interestRate, decimal monthlyPaymant) : 
            base(curentAcc.Owner, balance, curentAcc.AccountNumber.Substring(0, curentAcc.AccountNumber.Length-2) +"INT")
        {
            _intRate = interestRate;
            _mPay = monthlyPaymant;
        }

        public override void ShowAccountInfo()
        {
            Console.WriteLine("Interest Account:");
            base.ShowAccountInfo();
        }

        public void CalculateRateAfterMonths(int numberOfMonths,CreditAccount credAccBal,CurrentAccount curAccBal)
        {
            if (this.AccountNumber.Substring(0, AccountNumber.Length-3) == credAccBal.AccountNumber.Substring(0, credAccBal.AccountNumber.Length-4) 
                && (this.AccountNumber.Substring(0, AccountNumber.Length - 3) == curAccBal.AccountNumber.Substring(0, curAccBal.AccountNumber.Length - 2)))
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
    }
}
