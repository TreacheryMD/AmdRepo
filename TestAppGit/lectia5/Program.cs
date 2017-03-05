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

            draganelAccount.CashIn(5000);
            draganelAccount.CashOut(1000);

            draganelAccount.ShowAccountInfo();

            CreditAccount draganelCredit = new CreditAccount(draganelAccount, 200000, draganelAccount);
            draganelCredit.ShowAccountInfo();




        }
    }
}
