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
        public string Client { get;  }
        public string AccNum { get;  }
        public decimal Balance { get; private set;}

        public DateTime OpenDate { get;  }
        public string Currency { get; }

        protected BankAccount() { }
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

        protected BankAccount(string owner, decimal balance, string accountNumber, DateTime openDate, string currency)
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

        protected BankAccount(string line)
        {
            var l = line.Replace($"Type:{line.Split(new string[] { "Type:" }, StringSplitOptions.None).Last()}", "").Split('|');
            Client = l[0].Replace("Client:", "");
            AccNum = l[1].Replace(" AccountNumber:", "");
            Balance = Convert.ToDecimal(l[2].Replace(" Balance:", ""));
            OpenDate = DateTime.Parse(l[3].Replace("Open:", "").Replace(" ", ""));
            Currency = l[4].Replace(" Currency: ", "");
        }

        public override string ToString()
        {
            return $"Client: {Client} | AccountNumber:{AccNum} | Balance:{Balance} | Open: {OpenDate.ToShortDateString()} | Currency: {Currency}";
        }

        public void InBalance(decimal bal)
        {
            Balance += bal;
        }

        public void OutBalance(decimal bal)
        {
            Balance -= bal;
        }
    }
}
