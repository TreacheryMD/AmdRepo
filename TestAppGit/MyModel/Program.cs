using MyModel.Accounts;
using MyModel.Extension;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Clients;
using MyModel.Interfaces;
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

            BankAccount acc1 = new CurrentAccount(person1.FiscalCode,1000,"454654646545",DateTime.Now, CurrencyTypes.MDL);
            BankAccount acc2 = new CreditAccount(person1.FiscalCode, "454444454666",800,DateTime.Now, CurrencyTypes.MDL, new DateTime(2018, 01, 01));
            BankAccount acc3 = new DepositAccount(person2.FiscalCode, "3495782094785",39999,2.4,DateTime.Now, CurrencyTypes.MDL);     

            Exchange exchangeHandler = new Exchange();
            
            ListRepository<Transaction> listRepository = new ListRepository<Transaction>();

            TransferManager transferHandler = new TransferManager(exchangeHandler, listRepository);

            transferHandler.ExecuteTransfer(acc1, acc2,400);

            #region WriteReadTxt

            List<BankAccount> allAcc = new List<BankAccount>() { acc1, acc2,acc3 };
            IRepository<BankAccount> txtRep = new TxTBankAccRepository();
            txtRep.Add(allAcc);
            var test = txtRep.GetAll();

            #endregion


            Console.ReadLine();


        }
    }
}
