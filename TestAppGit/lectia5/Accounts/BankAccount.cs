using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
     abstract class BankAccount
    {
        public string Client { get;  set; }
        public string AccNum { get; set; }
        public decimal Balance { get; set; }
        public virtual void ShowAccountInfo()
        {
            Console.WriteLine($"\nAccount Owner: {Client} \nAccountNumber:{AccNum}\nBalance:{Balance} \n****************************\n");
        }
        protected BankAccount(string owner, decimal balance, string accountNumber)
        {
            while (string.IsNullOrWhiteSpace(owner))
            {
                Console.WriteLine("Owner format is incorect,enter new Owner:");
                this.Client = owner = Console.ReadLine();
            }

            this.AccNum = accountNumber;
            this.Balance = balance;
            this.Client = owner;
        }
    }
}
