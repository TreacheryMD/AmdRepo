using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Helper;

namespace MyModel.Accounts
{
    public abstract class BankAccount
    {
        private decimal _balance;

        public string Client { get;  }
        public string AccNum { get;  }
        public decimal Balance => _balance;

        public DateTime OpenDate { get;  }
        public string Currency { get; }

        public BankAccount() { }
        public virtual void ShowAccountInfo()
        {
            Console.Write(ToString());
        }
        public static void ShowAccountInfo(IEnumerable<BankAccount> yourEnum, bool showSorted = false,bool ascending = false)
        {
            if (showSorted)
            {
                yourEnum = ascending ? yourEnum.OrderBy(o => o.Balance) : yourEnum.OrderByDescending(o => o.Balance);
            }

            foreach (var item in yourEnum)
            {
                item.ShowAccountInfo();
            }
        }
        public BankAccount(string owner, decimal balance, string accountNumber, DateTime openDate, string currency)
        {
            if (string.IsNullOrEmpty(owner))
            {
                throw new ArgumentNullException(nameof(owner));
            }

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
