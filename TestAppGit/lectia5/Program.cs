using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using lectia5.Helper;

namespace lectia5
{
    class Program
    {
       
        static void Main(string[] args)
        {

            #region BankAccountsMoovments
            var JohnCrAcc = new CurrentAccount("Draganel", 0, "12213123");
            var JohnDpAcc = new DepositAccount(JohnCrAcc, 1000, 10);
            var JohnCredAcc = new CreditAccount(JohnCrAcc, 100000);
            var JohnInterest = new InterestAccount(JohnCrAcc, 3000, 5, 500);

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

            #region testing
#if !LIGHT
            //custom example
            //draganelCRacc.Restricted = true;
            try
            {
                JohnCrAcc.CashOut(500000);
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
            #endregion

            Console.ReadKey();
            #endregion

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

            Console.ReadLine();

        
         }
    }
}

        
   
    

