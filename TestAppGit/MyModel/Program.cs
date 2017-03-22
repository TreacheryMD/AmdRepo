using MyModel.Accounts;
using MyModel.Extension;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using IronPython.Hosting;
using MyModel.Repo;

namespace MyModel
{
    class Program
    {
        public delegate void ShowFunctionDelegate(IEnumerable<BankAccount> yourEnum);
        //private static Func<BankAccount, BankAccount, int> sortasda = (c1, c2) => { return c1.OpenDate.CompareTo(c2.OpenDate); };

        static void Main(string[] args)
        {
            var acc1 = new CurrentAccount("Draganel Ion", 500000, "157632541230", new DateTime(2017, 03, 10), "MDL");
            var acc2 = new CurrentAccount("Ursu Victor", 700000, "157632541231", new DateTime(2017, 02, 20), "EUR");
            var acc3 = new CurrentAccount("Potcovski Dumitru", 1000000, "157632541232", new DateTime(2013, 10, 20), "USD");
            var acc4 = new CurrentAccount("Olaru Daniel", 900000, "157632541233", new DateTime(2015, 11, 14), "EUR");
            var acc5 = new CurrentAccount("Hasdeu Petru ", 400000, "157632541234", new DateTime(2014, 09, 13), "MDL");
            var acc6 = new CurrentAccount("Gavrilita Alexandru", 400500, "157632541235", new DateTime(2017, 07, 05), "MDL");
            var acc7 = new CurrentAccount("Bradu Vladimir", -685000, "157632541236", new DateTime(2011, 11, 04), "USD");
            var acc8 = new CurrentAccount("Rau Viorel", 98500, "157632541237", new DateTime(2012, 05, 09), "MDL");
            var acc9 = new CurrentAccount("Semion Radu", 65000, "157632541238", new DateTime(2016, 06, 21), "USD");
            var acc10 = new CurrentAccount("Popov Ilie", 64800, "157632541239", new DateTime(2015, 04, 22), "MDL");
            var acc11 = new CurrentAccount("Rotaru Vasile", 98700, "157632541240", new DateTime(2014, 02, 24), "EUR");
            var acc12 = new CurrentAccount("Ciobanu Anatol", 354000, "157632541241", new DateTime(2017, 01, 17), "EUR");

            var acc13 = new CreditAccount(acc1.Client,acc1.AccNum,6000000,new DateTime(2017,01,01),"MDL",new DateTime(2030,01,01));
            var acc14 = new DepositAccount(acc1.Client,acc1.AccNum,5500000,4.50,new DateTime(2017,02,02),"MDL");
            var acc15 = new InterestAccount(acc1.Client, acc1.AccNum, 500000,6.33,5000,new DateTime(2017,03,03),"MDL" );

            //acc1.ShowAccountInfo();
            //acc14.ShowAccountInfo();

            List<BankAccount> allAcc = new List<BankAccount>() { acc1, acc2, acc3, acc4, acc5, acc6, acc7, acc8, acc9, acc10, acc11, acc12, acc13,acc14,acc15 };

            CurrentAccount test = new CurrentAccount();

            #region WriteReadTxt
            Repository repository = new Repository();
            repository.Add(allAcc);

            TxtReadWrite.WriteToTxt(repository.Get());

            var fromTxt = TxtReadWrite.ReadFromTxt();
            repository.Renew(fromTxt);

            #endregion

            #region EvolutionTaks

            //BankAccount.ShowAccountInfo(allAcc, true, true); // Method with optional parameters
            //Console.WriteLine(string.Concat(Enumerable.Repeat("*", 140)));
            //BankAccount.ShowAccountInfo(yourEnum:allAcc,showSorted:true); // using Named Arguments




            //#region dynamicSomeTesting
            ////Dynamic tests
            ////var testAcc = acc1;
            ////testAcc = acc14; //can t convert 

            ////dynamic testAccDynamic = acc1;
            ////testAccDynamic = acc14; // on runtime (but allow dynamic changes)

            ////scriptin runtime

            ////var PythonRuntime = Python.CreateRuntime();
            ////dynamic pythonFile = PythonRuntime.UseFile("Test.py");
            //////dynamic will allow me to bypass compile checking
            ////pythonFile.SayHelloToPython();
            //#endregion

            //#region exceptionFilters
            //try
            //{
            //    acc1.CashIn(500);
            //}
            //catch (Exception ex) when (ex.Message.Equals("You can't Cash In nothing to your current account"))
            //{
            //    Console.Write("First case");
            //}
            //catch (Exception ex) when (ex.Message.Equals("Integral constant is too large"))
            //{
            //    Console.Write("Second Case");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //#endregion

            //#region preconditionNameOf
            ////try
            ////{
            ////    var acc122 = new CurrentAccount("", 500000, "157632541230", new DateTime(2017, 03, 10), "MDL");
            ////}
            ////catch (Exception e)
            ////{
            ////    Console.WriteLine(e);
            ////    throw;
            ////}
            //#endregion


            #endregion

            #region BankAccountsMoovments


            //Repository newRepo = new Repository();
            //newRepo.Add(JohnCrAcc);
            //newRepo.Add(JohnDpAcc);
            //newRepo.Add(JohnCredAcc);
            //newRepo.Add(JohnInterest);

            //try { JohnCrAcc.CashIn(500000); }
            //catch (Exception ex) { Console.WriteLine(ex.Message); }

            //Console.WriteLine("Initial balance:");
            //JohnCrAcc.ShowAccountInfo();

            //JohnCrAcc.Transfer(JohnDpAcc, 100);

            //try
            //{
            //    Console.WriteLine("Transfer to deposit:");
            //    JohnCrAcc.ShowAccountInfo();
            //    JohnDpAcc.ShowAccountInfo();

            //    Console.WriteLine("Transfer to credit:");
            //    JohnCrAcc.Transfer(JohnCredAcc, 5555);
            //    JohnCrAcc.ShowAccountInfo();
            //    JohnCredAcc.ShowAccountInfo();
            //}
            //catch (AccountIsRestrictedException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //            #region testing
            //#if !LIGHT
            //            //custom example
            //            //draganelCRacc.Restricted = true;
            //            try
            //            {
            //                JohnCrAcc.CashOut(500000);
            //            }
            //            catch (AccountIsRestrictedException)
            //            {
            //                Console.WriteLine("This account is restricted");
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //#endif
            //            #endregion

            //Console.ReadKey();
            #endregion

            #region Banks
            //Bank victoriaBank = new Bank("Victoria Bank S.A.", "31 august 1981 bl. 141", 3, Bank.Reg.Chisinau);
            //Subsidiary subCalarasi = new Subsidiary("VB Calarasi", "Cuza Voda 31/2", Bank.Reg.Calarasi, null);
            //Subsidiary subCahul = new Subsidiary("VB Cahul", "Alexandru cel Bun 2", Bank.Reg.Cahul, 10);

            //List<Bank> organisation = new List<Bank>();
            //organisation.Add(victoriaBank);
            //organisation.Add(subCalarasi);
            //organisation.Add(subCahul);



            //foreach (var part in organisation)
            //{
            //    part.ShowInfo();
            //}

            //SubsidiaryEqualityComparer comWparer = new SubsidiaryEqualityComparer();
            //Console.WriteLine(comparer.Equals(subCalarasi, subCahul));
            //Console.WriteLine(comparer.GetHashCode(subCalarasi));
            #endregion


            Console.ReadLine();


        }
    }
}
