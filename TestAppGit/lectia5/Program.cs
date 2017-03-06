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
            CurrentAccount draganelCRacc = new CurrentAccount("Dragnael", 5000, "12213123");
            draganelCRacc.ShowAccountInfo();

            draganelCRacc.CashIn(500000);
            draganelCRacc.CashOut(1000);

            draganelCRacc.ShowAccountInfo();

            CreditAccount draganelCredit = new CreditAccount(draganelCRacc, 200000);
            draganelCredit.ShowAccountInfo();

            InterestAccount draganelInterest = new InterestAccount(draganelCRacc, 0, 13,5000);
            draganelInterest.CalculateRateAfterMonths(7, draganelCredit, draganelCRacc);
            draganelInterest.ShowAccountInfo();

            draganelCRacc.ShowAccountInfo();
            draganelCredit.ShowAccountInfo();

            DepositAccount draganelDepAcc = new DepositAccount(draganelCRacc, 10000, 10);
            draganelDepAcc.CalcDepAftMonths(10);

            draganelDepAcc.ShowAccountInfo();

            draganelCRacc.Transfer(draganelDepAcc, 3333);
            draganelDepAcc.ShowAccountInfo();
            draganelCRacc.ShowAccountInfo();

            Console.ReadKey();


        }
    }
}
