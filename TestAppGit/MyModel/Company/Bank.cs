using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Accounts;

namespace MyModel.Company
{
    class Bank
    {
        public enum Reg { Chisinau, AneniiNoi, Basarabeasca, Briceni, Cahul, Cantemir, Calarasi };

        public List<BankAccount> BankAccounts { get; }
        public int? Depots { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string BranchId { get; set; }

        public Reg Region { get; set; }
        

        public Bank(string name, string address, int? depots, Reg region, List<BankAccount> bankAccounts)
        {
            Name = name;
            Address = address;
            Depots = depots;
            BranchId = Branch.regDict[region];
            Region = region;
            BankAccounts = bankAccounts;
        }

        public Bank(string name, string address, int? depots, Reg region)
        {
            Name = name;
            Address = address;
            Depots = depots;
            Region = region;
        }

        public void AddNewBankAccounts(BankAccount account)
        {
            BankAccounts.Add(account);
        }

        public void AddNewBankAccounts(List<BankAccount> accounts)
        {
            BankAccounts.Concat(accounts);
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Bank name: {Name}, address: {Address}, depots: {Depots}, branch: {BranchId}, region: {Region}");
        }
    }
}
