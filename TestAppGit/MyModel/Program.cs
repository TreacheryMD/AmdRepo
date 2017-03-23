using MyModel.Accounts;
using MyModel.Extension;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Clients;
//using IronPython.Hosting;
using MyModel.Repo;

namespace MyModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ion", "Draganel", new DateTime(1991, 06, 10), "20050013346680", GenderType.Male);
            Person person2 = new Person();

            CurrentAccount acc1 = new CurrentAccount(person1.FiscalCode,0,"454654646545",DateTime.Now, CurrencyTypes.MDL);
            CreditAccount acc2 = new CreditAccount(person1.FiscalCode, acc1.AccNum,500,DateTime.Now, CurrencyTypes.MDL, new DateTime(2018, 01, 01));
            DepositAccount acc3 = new DepositAccount(person2.FiscalCode, "3495782094785",39999,2.4,DateTime.Now, CurrencyTypes.MDL);

            TransferMoney exchange = new TransferMoney();
            

            Console.WriteLine(person1);
            Console.WriteLine(acc1);
            Console.WriteLine(acc2);
            Console.WriteLine(acc3);

            #region WriteReadTxt

            //List<BankAccount> allAcc = new List<BankAccount>() { acc1, acc2 };
            //Repository repository = new Repository();
            //repository.Add(allAcc);

            //TxtReadWrite.WriteToTxt(repository.Get());

            //var fromTxt = TxtReadWrite.ReadFromTxt();
            //repository.Renew(fromTxt);

            #endregion

            Console.ReadLine();


        }
    }
}
