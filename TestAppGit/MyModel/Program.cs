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
using MyModel.Testing_proxy;

namespace MyModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ion", "Draganel", new DateTime(1991, 06, 10), "20050013346680", GenderType.Male);
            Person person2 = new Person();

            BankAccount acc1 = new CurrentAccount(person1.FiscalCode,1100,"454654646545",DateTime.Now, CurrencyTypes.MDL);
            BankAccount acc2 = new CreditAccount(person1.FiscalCode, "454444454666",0,DateTime.Now, CurrencyTypes.MDL, new DateTime(2018, 01, 01));
            BankAccount acc3 = new DepositAccount(person2.FiscalCode, "3495782094785",40000,2.4,DateTime.Now, CurrencyTypes.MDL);

            IServiceLocator locator = new ServiceLocator();
            var myservice = locator.GetService<IRepository<Transaction>>();

            TransferManager transferHandler = new TransferManager(myservice);
            transferHandler.ExecuteTransfer(acc1, acc3,1000);
            Console.WriteLine(acc1);
            Console.WriteLine(acc3);

            #region WriteReadTxt

            List<BankAccount> allAcc = new List<BankAccount>() { acc1, acc2, acc3 };
            IRepository<BankAccount> txtRep = new TxTBankAccRepository();
            txtRep.Add(allAcc);
            var test = txtRep.GetAll();

            #endregion


            Console.ReadLine();


        }
    }
}
