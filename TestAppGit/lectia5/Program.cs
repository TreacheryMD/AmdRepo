using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount draganelAccount = new CurrentAccount("Dragnael", 5000, "12213123");
            draganelAccount.ShowAccountInfo();

            draganelAccount.CashIn(500000);
            draganelAccount.CashOut(1000);

            draganelAccount.ShowAccountInfo();

            CreditAccount draganelCredit = new CreditAccount(draganelAccount, 200000, draganelAccount);
            draganelCredit.ShowAccountInfo();

            InterestAccount draganelInterest = new InterestAccount(draganelAccount, 0, draganelAccount, 13,5000);
            draganelInterest.CalculateRateAfterMonths(7, draganelCredit, draganelAccount);
            draganelInterest.ShowAccountInfo();

            draganelAccount.ShowAccountInfo();
            draganelCredit.ShowAccountInfo();

            DepositAccount draganelDepAcc = new DepositAccount(draganelAccount, 100, draganelAccount, 1.5d);
            draganelDepAcc.CalcDepAftMonths(5);

            Console.ReadKey();


        }
    }
}
