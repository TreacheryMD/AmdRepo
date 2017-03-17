using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModel.Accounts
{
    public abstract class BankAccount
    {
        private decimal _balance;

        public string Client { get;  }
        public string AccNum { get;  }
        public decimal Balance {
            get { return _balance; } 
        }
        public DateTime OpenDate { get;  }
        public string Currency { get; }

        public BankAccount() { }
        public virtual void ShowAccountInfo()
        {
            Console.Write(this.ToString());
        }
        public static void ShowAccountInfo(IEnumerable<BankAccount> yourEnum)
        {
            foreach (var item in yourEnum)
            {
                item.ShowAccountInfo();
            }
        }
        public BankAccount(string owner, decimal balance, string accountNumber, DateTime openDate, string currency)
        {
            while (string.IsNullOrWhiteSpace(owner))
            {
                Console.WriteLine("Client format is incorect,enter new Client:");
                Client = owner = Console.ReadLine();
            }

            AccNum = accountNumber;
            this.InBalance(balance);
            Client = owner;
            OpenDate = openDate;
            Currency = currency;
        }

        public override string ToString()
        {
            return $"Client: {Client} | AccountNumber:{AccNum} | Balance:{Balance} | Open: {OpenDate.ToShortDateString()} | Currency: {Currency}";
        }

        public void InBalance(decimal bal)
        {
            _balance += bal;
        }

        public void OutBalance(decimal bal)
        {
            _balance -= bal;
        }
    }
}
