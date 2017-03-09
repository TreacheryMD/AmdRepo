using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace lectia5
{
    class Program
    {
        static void Main(string[] args)
        {
            var draganelCRacc = new CurrentAccount("Draganel", 0, "12213123");
            draganelCRacc.ShowAccountInfo();
            try
            {
                draganelCRacc.CashIn(500000);
               // draganelCRacc.CashOut(5000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);
            }

           

            //custom example
            //draganelCRacc.Restricted = true;
#if !LIGHT
            try
            {
                draganelCRacc.CashOut(500000);
            }
            catch (AccountIsRestrictedException)
            {
                Console.WriteLine("This account is restricted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
#endif
            //DebugClassTesting.Run();

            //draganelCRacc.ShowAccountInfo();

            //CreditAccount draganelCredit = new CreditAccount(draganelCRacc, 200000);
            //draganelCredit.ShowAccountInfo();

            //InterestAccount draganelInterest = new InterestAccount(draganelCRacc, 0, 13, 5000);
            //draganelInterest.CalculateRateAfterMonths(7, draganelCredit, draganelCRacc);
            //draganelInterest.ShowAccountInfo();

            //draganelCRacc.ShowAccountInfo();
            //draganelCredit.ShowAccountInfo();

            DepositAccount draganelDepAcc = new DepositAccount(draganelCRacc, 10000, 10);
            draganelDepAcc.CalcDepAftMonths(0);
            draganelCRacc.Transfer(draganelDepAcc, 200000);
            draganelDepAcc.ShowAccountInfo();
            draganelCRacc.ShowAccountInfo();

            //draganelCRacc.Transfer(draganelDepAcc, 3333);
            //draganelDepAcc.ShowAccountInfo();
            //draganelCRacc.ShowAccountInfo();

            Console.ReadKey();


        }
    }
}
