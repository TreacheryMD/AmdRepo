﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using lectia5.Helper;
using System.Data;
using lectia5.TemporarExamples;

namespace lectia5
{
    class Program
    {
        public delegate void ShowFunctionDelegate(IEnumerable<BankAccount> yourEnum);
        private static Func<BankAccount, BankAccount, int> sortasda = (c1, c2) => { return c1.OpenDate.CompareTo(c2.OpenDate); };

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
            var acc11 = new CurrentAccount("Rotaru Vasile", 98700, "157632541240", new DateTime(2014, 02, 24), "EUR");//
            var acc12 = new CurrentAccount("Ciobanu Anatol", 354000, "157632541241", new DateTime(2017, 01, 17), "EUR");

            var acc13 = new CurrentAccount("Bradu Vladimir", 685000, "157632541242", new DateTime(2011, 11, 04), "USD");
            var acc14 = new CurrentAccount("Rau Viorel", 98500, "157632541243", new DateTime(2012, 05, 09), "MDL");
            var acc15 = new CurrentAccount("Semion Radu", 65000, "157632541244", new DateTime(2016, 06, 21), "USD");

            var dublicate = new CurrentAccount("Semion Radu", 65000, "157632541244", new DateTime(2016, 06, 21), "USD");//intentional

            var acc16 = new CurrentAccount("Popov Ilie", -64800, "157632541245", new DateTime(2015, 04, 22), "MDL");
            var acc17 = new CurrentAccount("Rotaru Vasile", 98700, "157632541246", new DateTime(2014, 02, 24), "EUR");
            var acc18 = new CurrentAccount("Ciobanu Anatol", 354000, "157632541247", new DateTime(2017, 01, 17), "EUR");



            List<BankAccount> allAcc = new List<BankAccount>() { acc1, acc2, acc3, acc4, acc5, acc6, acc7, acc8, acc9, acc10,
                                                                 acc11, acc12, acc13, acc14, acc15, acc15, acc16, acc17, acc18 };

            //allAcc.FilterNegativeBankAccounts();

            #region Task10 

            ////delegate > type safe function pointer (signature of delegate must match the signature of the function)

            ////just for example (basics) 
            //ShowFunctionDelegate del = new ShowFunctionDelegate(BankAccount.ShowAccountInfo);
            //del(allAcc);

            ////delegate usage example
            //// i have an method in Taks10 class that restrict accounts from List of currentAccounts 
            //// that will restrict based on balance property only (if (acc.Balance>600000))

            //List<CurrentAccount> allCRAcc = new List<CurrentAccount>() { acc1, acc2, acc3 };

            //Task10.RestrictAccountHardCoded(allCRAcc);
            //Console.WriteLine("***");
            //del(allCRAcc);

            //// we want REUSABLE METHOD code (not hard coded) (method Fix) in Task10 class
            //// declaring new in IsRestrictable delegate and pars in as parammeter

            ////first: declare Delegate and parse (function that have boolean return type and //user function
            ////wich take currentAccount object as parammeter)

            //IsRestrictable isRestrictable = new IsRestrictable(Task10.Restrict);

            //Task10.FixRestrictAccount(allCRAcc, isRestrictable);
            //Console.WriteLine("***");
            //del(allCRAcc);

            //// our method FirstFix is not hard coded any more

            ////second fix: using Lambda Expression (anonymous functions)

            //Task10.FixRestrictAccount(allCRAcc, acc=>acc.Balance > 7000000); // and we dont need more Restrict Method

            //// new 3.5 delegate Func

            //Task10.SecondFixUnrestrict(allCRAcc, acc => acc.Restricted == true);
            //Console.WriteLine("***");
            //del(allCRAcc);

            ////--some sorts
            //

            //allAcc.Sort((BankAccount c1, BankAccount c2) => { return c1.OpenDate.CompareTo(c2.OpenDate); });
            //BankAccount.ShowAccountInfo(allAcc);
            //Console.WriteLine("*****");
            //allAcc.Sort(delegate (BankAccount c1, BankAccount c2) { return c2.OpenDate.CompareTo(c1.OpenDate); });
            //BankAccount.ShowAccountInfo(allAcc);

            #endregion

            #region Extension

            DataTable records = allAcc.ListToDataTable("All Records");
            //var test = allAcc.FilterNegativeBankAccounts();
            // BankAccount.ShowAccountInfo(test);

            var newType = allAcc.Where(w => w.OpenDate > new DateTime(2014, 06, 10))
                  .Select(s => new
                  {
                      clientRef = s.Client,
                      balance = s.Balance,
                  }).OrderByDescending(o => o.balance);

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

            //SubsidiaryEqualityComparer comparer = new SubsidiaryEqualityComparer();
            //Console.WriteLine(comparer.Equals(subCalarasi, subCahul));
            //Console.WriteLine(comparer.GetHashCode(subCalarasi));
            #endregion

            #region Taks13 Advanced Linq

            var queryFiltering = allAcc.Skip(10)
                                     .Take(7)
                                     .TakeWhile(t => t.Balance >= 0)
                                     .SkipWhile(s => s.OpenDate > new DateTime(2013, 10, 01))
                                     .Where(w => w.Client.Length > 4)
                                     .Distinct();

            var queryProjection = allAcc.Select(s => new { renamedField = s.Client, s.Balance });


            #region declaring
            Bank victoriaBank = new Bank("Victoria Bank S.A.", "31 august 1981 bl. 141", 3, Bank.Reg.Chisinau);
            Bank moldIncomBank = new Bank("MoldIncomBank", "Mircea cel Batran 3/1", 10, Bank.Reg.Chisinau);

            List<Subsidiary> victorias = new List<Subsidiary>() { new Subsidiary("VB Calarasi", "Cuza Voda 31/2", Bank.Reg.Calarasi), new Subsidiary("VB Cahul", "Alexandru cel Bun 2", Bank.Reg.Cahul) };
            List<Subsidiary> mibList = new List<Subsidiary>() { new Subsidiary("MIB Calarasi", "Eminesc 1/2", Bank.Reg.Calarasi) };
            victoriaBank.SubsidiaryList = victorias;
            moldIncomBank.SubsidiaryList = mibList;
            List<Bank> bankList = new List<Bank>() { victoriaBank, moldIncomBank };
            #endregion

            var queryProjectionMany = bankList.SelectMany(s => s.SubsidiaryList);
            var queryProjectionMany2 = bankList.SelectMany(s => s.SubsidiaryList, (parent, child)
                                               => new
                                               {
                                                   parent.Name,
                                                   child.SubName,
                                                   child.SubRegion,
                                               });
           
            List<BankAccount> newAccList = new List<BankAccount>() { acc1, acc2 };
            List<BankAccount> newAccLis2t = new List<BankAccount>() { acc1, acc2, acc3, acc4 };
           
            var joining = allAcc.Join(newAccList,
                f => f.Client,
                s => s.Client,
                (f, s) => f);

            #region declaring2
            var customers = new Customer[]
                {
                    new Customer{Code = 5, Name = "Sam"},
                    new Customer{Code = 6, Name = "Dave"},
                    new Customer{Code = 7, Name = "Julia"},
                    new Customer{Code = 8, Name = "Sue"}
                };
            var orders = new Order[]
                {
                    new Order {KeyCode = 7, Product = "Computer"},
                    new Order {KeyCode = 7, Product = "Mouse"},
                    new Order {KeyCode = 8, Product = "Shirt"},
                    new Order {KeyCode = 5, Product = "Underwear"}
                };
            #endregion

            var groupJoin = customers.GroupJoin(orders,
            c => c.Code,
            o => o.KeyCode,
            (c, result) => new Result(c.Name, result));

            var zipTest = newAccList.Zip(newAccLis2t, (l, l2) => (l.Balance + l2.Balance)); // just for test

            var orderDesc = allAcc.OrderByDescending(o => o.Balance);
            var orderAsc = allAcc.OrderBy(o => o.OpenDate);
            var mixtOrder = allAcc.OrderBy(o => o.Client).ThenByDescending(d => d.Balance).ThenBy(tb => tb.OpenDate);
            var reverse = mixtOrder.Reverse();

            var querrygrouBy = allAcc.GroupBy(g => g.Client)
                               .Select(s =>
                               new {
                                   ClientName = s.Key,
                                   sum = s.Sum(sum=>sum.Balance)
                               });

            List<decimal> someNumbers = new List<decimal>();
            someNumbers.Add(querrygrouBy.Count());
            someNumbers.Add(querrygrouBy.Max(max => max.sum));
            someNumbers.Add(querrygrouBy.Min(min => min.sum));
            someNumbers.Add(querrygrouBy.Average(av => av.sum));
            someNumbers.Add(querrygrouBy.Count());

            var chars = new[] { "a", "b", "c", "d" };
            var csv = chars.Aggregate((a, b) => a + ',' + b);

            bool contains = newAccList.Contains(acc1);
            bool any = newAccList.Any();
            bool anySecond = newAccLis2t.Any(a => a.Currency == "MDL");
            bool allRes = newAccLis2t.All(all => all.Balance > 0);
            bool seqEqual = newAccLis2t.SequenceEqual(newAccList);

            var emptyCollection1 = Enumerable.Empty<string>();
            var coll = Enumerable.Repeat("d", 20);
            var intCollection = Enumerable.Range(30,10);

            #endregion




            Console.ReadLine();


        }
    }
}





